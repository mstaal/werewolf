using System;
using System.Collections.Generic;
using System.Linq;
using Werewolf.Logic;

namespace Werewolf.Models
{
    public class Board
    {
        private List<CharacterType> activeCharacters;

        public string ID { get; set; }
        public List<CharacterType> CharactersInPile { get; set; }
        public List<CharacterType> ActiveCharacters
        {
            get { return activeCharacters; }
            set
            {
                Progress = this.GameOrder();
                this.activeCharacters = value;
                Progress.RemoveAll(a => !value.Contains(a));
            }
        }
        public List<CharacterType> Progress { get; set; }


        private Character MakeCharacter(CharacterType character)
        {
            switch (character)
            {
                case CharacterType.Villager:
                    return new Villager(this);
                case CharacterType.Seer:
                    return new Seer(this);
                case CharacterType.Robber:
                    return new Robber(this);
                case CharacterType.Hunter:
                    return new Hunter(this);
                case CharacterType.Mason:
                    return new Mason(this);
                case CharacterType.Insomniac:
                    return new Insomniac(this);
                case CharacterType.Doppelganger:
                    return new Doppelganger(this);
                case CharacterType.Drunk:
                    return new Drunk(this);
                case CharacterType.Werewolf:
                    return new Werewolf(this);
                case CharacterType.Minion:
                    return new Minion(this);
                case CharacterType.Tanner:
                    return new Tanner(this);
                default:
                    throw new ArgumentException("Unsupported character");
            }
        }

        public List<Character> MakeCharacters(List<CharacterType> characters)
        {
            var result = new List<Character>();
            foreach(var character in characters)
            {
                result.Add(MakeCharacter(character));
            }
            return result;
        }

        public List<Character> MakeCharacters()
        {
            var result = this.MakeCharacters(this.ActiveCharacters);
            result.Shuffle();
            return result;
        }

        //private List<Character> GenerateCharacters()
        //{
        //    Random rnd = new Random();
        //    List<CharacterType> pile = this.CharactersInPile;
        //    List<Character> characters = new List<Character>();
        //    for (int i = 0; i < pile.Count - 3; i++)
        //    {
        //        int index = rnd.Next(pile.Count);
        //        characters.Add(MakeCharacter(pile[index]));
        //        pile.RemoveAt(index);
        //    }

        //    return characters;
        //}

        private List<CharacterType> GameOrder()
        {
            return new List<CharacterType>()
            {
                CharacterType.Doppelganger,
                CharacterType.Werewolf,
                CharacterType.Seer,
                CharacterType.Robber,
                CharacterType.Troublemaker,
                CharacterType.Drunk,
                CharacterType.Insomniac
            };
        }
    }
}
