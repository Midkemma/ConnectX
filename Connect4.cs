using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectX
{
    class Connect4
    {
        //2D array for board.
        private char[,] _gameBoard;
        //List of player.
        List<Player> _players;


        





        //==========================================================================================
        public Connect4(Player playerA, Player playerB)
        {
            _gameBoard = new char[7, 6];
            _players = new List<Player>();
            //Add at least 2 players to Player list
            _players.Add(playerA);
            _players.Add(playerB);






        }// End of Constructor.
        //==========================================================================================




        //==========================================================================================
    }// End of Class.
}
