using System;
namespace Werewolf.Models
{
    public class Minion : Character
    {
        public Minion(Board game) : base(game, CharacterType.Minion)
        {
        }
    }
}
