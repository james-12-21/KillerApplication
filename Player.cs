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
        public bool PlayerTurn { get; set; }
        public int NumberOfBallsToPot { get; set; }

        public Player()
        {

        }

        public Player(int playerId, string playerName)
        {
            this.PlayerId = playerId;
            this.PlayerName = playerName;
            this.PlayerLives = 4;
            this.PlayerTurn = false;
        }
        public Player(int playerId, string playerName, int playerLives)
        {
            this.PlayerId = playerId;
            this.PlayerName = playerName;
            this.PlayerLives = playerLives;
            this.PlayerTurn = false;
        }
        
        public static int NextPlayerTurn(Player player)
        {
            if (player.PlayerTurn)
            {
                return player.PlayerId;
            }
            else
            {
                return -1;
            }
        }
        public bool CheckPlayerIsAlive(int playerId, Player player)
        {
            int playersLives = player.PlayerLives;
            if(playersLives == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
