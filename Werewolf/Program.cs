using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Werewolf.Dirigent;
using Werewolf.Models;

namespace Werewolf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Board board = GameFactory.BuildBoard("villager", "villager", "werewolf", "seer", "robber", "tanner");
            User user = new User
            {
                Mail = "m@mstaal.com"
            };
            User user2 = new User
            {
                Mail = "m87877899878879786668787yggvftv f vyubytfvvvy"
            };
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
