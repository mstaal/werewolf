using System;
using Werewolf.Dirigent;
using System.Collections.Generic;
using System.Linq;
using Werewolf.Logic;
using Werewolf.Models;

namespace Werewolf.Dirigent
{
    public static class GameFactory
    {

        public static Board BuildBoard(params string[] texts)
        {
            return BuildBoard(CharacterMethods.FromString(texts));
        }

        public static Board BuildBoard(List<string> texts)
        {
            return BuildBoard(CharacterMethods.FromString(texts.ToArray()));
        }

        public static Board BuildBoard(params CharacterType[] types)
        {
            return BuildBoard(types.ToList());
        }

        public static Board BuildBoard(List<CharacterType> types)
        {
            if(types.Count > 5)
            {
                var listNumbers = Enumerable.Range(0, types.Count).ToList();
                listNumbers.Shuffle();
                var active = new List<CharacterType>();
                var pile = new List<CharacterType>();
                for (int i = 0; i < types.Count - 3; i++)
                {
                    active.Add(types[listNumbers[i]]);
                }
                for (int i = types.Count - 3; i < types.Count; i++)
                {
                    pile.Add(types[listNumbers[i]]);
                }

                return new Board
                {
                    CharactersInPile = pile,
                    ActiveCharacters = active
                };
            }
            throw new ArgumentOutOfRangeException("Specify more than 5 types");
        }

        public static List<Character> BuildCharacters(Board board)
        {
            return board.MakeCharacters();
        }

        public static List<Character> BuildCharacters(params string[] texts)
        {
            return BuildBoard(texts).MakeCharacters();
        }

        public static List<Character> BuildCharacters(List<string> texts)
        {
            return BuildBoard(texts).MakeCharacters();
        }

        public static List<User> GamifyUsers(List<User> users, List<string> texts)
        {
            if (users.Count == texts.Count)
            {
                var characters = BuildCharacters(texts);
                for (int i = 0; i < users.Count; i++)
                {
                    users[i].Character = characters[i];
                }
                return users;
            }

            throw new ArgumentOutOfRangeException();
        }

        public static Game BuildGame(User user, List<User> users)
        {
            var game = new Game(user);
            game.AddPlayers(users);
            return game;
        }
    }
}
