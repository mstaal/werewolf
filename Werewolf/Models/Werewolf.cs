using System;
namespace Werewolf.Models
{
    public class Werewolf : Character
    {
        public Werewolf(Board game) : base(game, CharacterType.Werewolf)
        {
        }

        public override void SpecialAbillity(params Character[] characters)
        {
            int count = 0;
            foreach (CharacterType type in base.Board.ActiveCharacters)
            {
                if (type == CharacterType.Werewolf)
                {
                    count += 1;
                }
                if (count >= 2) { break; }
            }
            if (count == 1 && base.InGameInfo.Count == 0)
            {
                int position = new Random().Next(base.Board.CharactersInPile.Count);
                var pileCharac = base.Board.CharactersInPile[position].GetString();
                base.InGameInfo.Add($"Card in pile: {pileCharac}");
            }
        }
    }
}
