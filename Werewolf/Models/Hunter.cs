using System;
namespace Werewolf.Models
{
    public class Hunter : Character
    {
        public Hunter(Board game) : base(game, CharacterType.Hunter)
        {
        }
    }
}
