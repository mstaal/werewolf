using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Werewolf.Models
{
    public enum CharacterType
    {
        Villager,
        Seer,
        Troublemaker,
        Robber,
        Hunter,
        Mason,
        Insomniac,
        Doppelganger,
        Drunk,
        Werewolf,
        Minion,
        Tanner
    }

    public enum Team
    {
        Villagers,
        Werewolfs,
        Tanner
    }

    public static class CharacterMethods
    {
        public static string GetString(this CharacterType charac)
        {
            switch (charac)
            {
                case CharacterType.Villager:
                    return "Villager";
                case CharacterType.Seer:
                    return "Seer";
                case CharacterType.Troublemaker:
                    return "Troublemaker";
                case CharacterType.Robber:
                    return "Robber";
                case CharacterType.Hunter:
                    return "Hunter";
                case CharacterType.Mason:
                    return "Mason";
                case CharacterType.Insomniac:
                    return "Insomniac";
                case CharacterType.Doppelganger:
                    return "Doppelganger";
                case CharacterType.Drunk:
                    return "Drunk";
                case CharacterType.Werewolf:
                    return "Werewolf";
                case CharacterType.Minion:
                    return "Minion";
                case CharacterType.Tanner:
                    return "Tanner";
                default:
                    return "Error";
            }
        }

        public static Team GetTeam(this CharacterType charac)
        {
            switch (charac)
            {
                case CharacterType.Werewolf:
                case CharacterType.Minion:
                    return Team.Werewolfs;
                case CharacterType.Tanner:
                    return Team.Tanner;
                default:
                    return Team.Villagers;
            }
        }

        public static List<CharacterType> FromString(params string[] texts)
        {
            var result = new List<CharacterType>();
            foreach (var text in texts)
            {
                switch(text.ToLower())
                {
                    case "villager":
                        result.Add(CharacterType.Villager);
                        break;
                    case "seer":
                        result.Add(CharacterType.Seer);
                        break;
                    case "troublemaker":
                        result.Add(CharacterType.Troublemaker);
                        break;
                    case "robber":
                        result.Add(CharacterType.Robber);
                        break;
                    case "hunter":
                        result.Add(CharacterType.Hunter);
                        break;
                    case "mason":
                        result.Add(CharacterType.Mason);
                        break;
                    case "insomniac":
                        result.Add(CharacterType.Insomniac);
                        break;
                    case "doppelganger":
                        result.Add(CharacterType.Doppelganger);
                        break;
                    case "drunk":
                        result.Add(CharacterType.Drunk);
                        break;
                    case "werewolf":
                        result.Add(CharacterType.Werewolf);
                        break;
                    case "minion":
                        result.Add(CharacterType.Minion);
                        break;
                    case "tanner":
                        result.Add(CharacterType.Tanner);
                        break;
                }
            }
            return result;
        }
    }
}