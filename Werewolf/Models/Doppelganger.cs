using System;
namespace Werewolf.Models
{
    public class Doppelganger : Character
    {
        public Doppelganger(Board game) : base(game, CharacterType.Doppelganger)
        {
        }

        public override void SpecialAbillity(params Character[] characters)
        {
            this.CurrentCharacter = characters[0].CurrentCharacter;
        }
    }
}
