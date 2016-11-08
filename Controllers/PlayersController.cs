using Microsoft.AspNetCore.Mvc;
using FantasyFootballApi.Player;
using System.Collections.Generic;

namespace FantasyFootball.Players 
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        [HttpGet]
        public List<Player> GetAllPlayers()
        {
            var PlayersList = new List<Player>();

            PlayersList.Add(new Player { Name = "Mesut Ozil", Team = "Arsenal"});
            PlayersList.Add(new Player { Name = "Sergio Aguero", Team = "Manchester City"});
            
            return PlayersList;
        }
    }
}