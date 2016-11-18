
using System.ComponentModel.DataAnnotations;

namespace FantasyFootballApi.Player
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public double Value { get; set; }
        public string Position { get; set; }
    }
}
