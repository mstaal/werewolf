using System;
namespace Werewolf.Models
{
    public class Drunk : Character
    {
        public Drunk(Board game) : base(game, CharacterType.Drunk)
        {
        }

        public override void SpecialAbillity(params Character[] characters)
        {
            int position = new Random().Next(base.Board.CharactersInPile.Count);
            this.CurrentCharacter = base.Board.CharactersInPile[position];
        }
    }
}
