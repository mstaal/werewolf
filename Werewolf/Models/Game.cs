using System;
using System.Linq;
using System.Collections.Generic;

namespace Werewolf.Models
{
    public class Game
    {
        public List<User> Users { get; set; }
        public string ID { get; private set; }

        public Game(User user)
        {
            this.Users = new List<User>
            {
                user
            };
            this.ID = user.ID;
        }

        public void AddPlayer(User user)
        {
            if (!this.Users.Contains(user))
            {
                this.Users.Add(user);
            }
        }

        public void AddPlayers(List<User> users)
        {
            users.ForEach(x => this.AddPlayer(x));
        }

        public void SetAdmin(User user)
        {
            if (this.Users.Contains(user))
            {
                this.ID = user.ID;
            }
            else
            {
                throw new AccessViolationException("User is not in game");
            }
        }
    }
}
