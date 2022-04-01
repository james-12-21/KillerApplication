using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerLives { get; set; }

        public Player(int playerId, string playerName)
        {
            this.PlayerId = playerId;
            this.PlayerName = playerName;
        }
        public Player(int playerId, string playerName, int playerLives)
        {
            this.PlayerId = playerId;
            this.PlayerName = playerName;
            this.PlayerLives = playerLives;
        }
        
    }
}
