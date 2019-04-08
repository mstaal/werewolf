using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Werewolf.Dirigent;
using Werewolf.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Werewolf.Controllers
{
    [Route("[controller]")]
    public class GameController : Controller
    {
        // GET: api/values
        [HttpGet("{makeboard}")]
        public IEnumerable<string> Get(string characters)
        {
            List<string> listOfCharacters = characters.Split(";").ToList();
            List<Character> stuff = GameFactory.BuildCharacters(listOfCharacters);
            return new string[] { "value1", "value2" };
        }
    }
}
