using Werewolf.Logic;

namespace Werewolf.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public Character Character { get; set; }
        public string Id => Mail.CreateMd5();

        public void ApplyAbillity(string id, params Character[] characters)
        {
            if (id == this.Id)
            {
                Character?.ApplyAbillity(characters);
            }
        }
    }
}
