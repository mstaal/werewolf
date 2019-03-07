using System;
namespace Werewolf.Models
{
    public class Troublemaker : Character
    {
        public Troublemaker(Board board) : base(board, CharacterType.Troublemaker)
        {
        }

        public override void SpecialAbillity(params Character[] characters)
        {
            CharacterType firstType = characters[0].CurrentCharacter;
            characters[0].CurrentCharacter = characters[1].CurrentCharacter;
            characters[1].CurrentCharacter = firstType;
        }
    }
}
