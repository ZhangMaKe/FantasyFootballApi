using Microsoft.AspNetCore.Mvc;
using FantasyFootballApi.Player;
using System.Collections.Generic;

namespace FantasyFootball.Players 
{
    
    public class PlayersController : Controller
    {
        [HttpGet]
        [Route("api/[controller]/GetAllPlayers")]
        public Player[] GetAllPlayers()
        {
            var PlayersList = new List<Player>();

            PlayersList.Add(new Player { Name = "Mesut Ozil", Team = "Arsenal", 
            Value = 4.5, Position = "MID"});
            PlayersList.Add(new Player { Name = "Sergio Aguero", 
            Team = "Manchester City", Value = 12, Position = "ATT"});
            
            return PlayersList.ToArray();
        }

        [HttpGet]
        [Route("api/[controller]/GetPlayerByTeam")]
        public Player[] GetPlayerByTeam()
        {
            var PlayersList = new List<Player>();
            PlayersList.Add(new Player { Name = "Alexis Sanchez", Team = "Arsenal"});

            return PlayersList.ToArray();
        }
    }
}