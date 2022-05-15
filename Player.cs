using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    public class Player
    {
        internal int PlayerId { get; set; }
        internal string PlayerName { get; set; }
        internal int PlayerLives { get; set; }
        internal bool PlayerTurn { get; set; }
        internal int NumberOfBallsToPot { get; set; }
        internal bool PlayerFruits { get; set; }
        internal string ColourOfFruit { get; set; }

        public List<Player> PlayerList { get; set;}

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
        
        public bool IsPlayerTurn(List<Player> players, int playerIndex)
        {
            if (players[playerIndex].PlayerTurn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckPlayerIsAlive(List<Player> players, int playerIndex)
        {
            if (players[playerIndex].PlayerLives == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddPlayerToResultList(List<Player> players, int playerIndex, List<Player> result)
        {
            if(!CheckPlayerIsAlive(players, playerIndex))
            {
                result.Add(players[playerIndex]);
            }
        }
    }
}
