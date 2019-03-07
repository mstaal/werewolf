using System;
namespace Werewolf.Models
{
    public class Insomniac : Character
    {
        public Insomniac(Board game) : base(game, CharacterType.Insomniac)
        {
        }

        public override void SpecialAbillity(params Character[] characters)
        {
            if (base.InGameInfo.Count == 0)
            {
                base.InGameInfo.Add($"Current character: {base.CurrentCharacter.GetString()}");
            }
        }
    }
}
