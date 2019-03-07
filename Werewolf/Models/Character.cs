using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Werewolf.Models
{
    public abstract class Character
    {
        public CharacterType OriginalCharacter { get; }
        public CharacterType CurrentCharacter { get; set; }
        public List<string> InGameInfo { get; set; }
        public Board Board { get; }
        public string CurrentCharacterString
        {
            get { return this.CurrentCharacter.GetString(); }
        }

        protected Character(Board board, CharacterType character)
        {
            this.OriginalCharacter = character;
            this.CurrentCharacter = character;
            this.InGameInfo = new List<string>();
            this.Board = board;

            this.Board.CharactersInPile.Add(character);
        }

        public void ApplyAbillity(params Character[] characters)
        {
            var progress = this.Board.Progress;
            if (progress.Count > 0 && this.OriginalCharacter == progress[0])
            {
                SpecialAbillity(characters);
                this.Board.Progress.RemoveAt(0);
            }
        }

        public virtual void SpecialAbillity(params Character[] characters)
        {
        }

        public string InGameInfoAsString()
        {
            var result = "";
            this.GetType().ToString();
            foreach (var info in this.InGameInfo)
            {
                result += $"{info}\n";
            }
            return result;
        }

    }
}
