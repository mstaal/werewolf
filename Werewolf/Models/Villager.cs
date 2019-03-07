using System;
namespace Werewolf.Models
{
    public class Villager : Character
    {
        public Villager(Board board) : base(board, CharacterType.Villager)
        {
        }
    }
}
