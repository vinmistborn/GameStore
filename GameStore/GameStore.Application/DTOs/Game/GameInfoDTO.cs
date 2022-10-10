using System.Collections.Generic;

namespace GameStore.Application.DTOs.Game
{
    public class GameInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string PhotoUrl { get; set; }        
    }
}
