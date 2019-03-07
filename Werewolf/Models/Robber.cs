using System;
namespace Werewolf.Models
{
    public class Robber : Character
    {
        public Robber(Board game) : base(game, CharacterType.Robber)
        {
        }

        public override void SpecialAbillity(params Character[] characters)
        {
            if (characters.Length >= 1)
            {
                CharacterType currentType = this.CurrentCharacter;
                this.CurrentCharacter = characters[0].CurrentCharacter;
                characters[0].CurrentCharacter = currentType;
            }
        }
    }
}
