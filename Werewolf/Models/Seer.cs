using System;
namespace Werewolf.Models
{
    public class Seer : Character
    {
        public Seer(Board game) : base(game, CharacterType.Seer)
        {
        }

        public override void SpecialAbillity(params Character[] characters)
        {
            if (characters.Length >= 1 && base.InGameInfo.Count == 0)
            {
                if (base.Board.ActiveCharacters.Contains(characters[0].CurrentCharacter))
                {
                    base.InGameInfo.Add(
                    $"Chosen card: {characters[0].CurrentCharacter.GetString()}"
                        );
                }
            }
            else if (base.InGameInfo.Count == 0)
            {
                int position1 = new Random().Next(base.Board.CharactersInPile.Count);
                int position2 = new Random().Next(base.Board.CharactersInPile.Count);
                while (position1 == position2)
                {
                    position2 = new Random().Next(base.Board.CharactersInPile.Count);
                }
                var charac1 = base.Board.CharactersInPile[position1].GetString();
                var charac2 = base.Board.CharactersInPile[position2].GetString();
                base.InGameInfo.Add($"1st card from pile: {charac1}");
                base.InGameInfo.Add($"2nd card from pile: {charac2}");
            }
        }
    }
}
