using System;
using System.Collections.Generic;
using System.Drawing;
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
        public void draw(Graphics l, int height, int width)
        {
            Pen p = new Pen(Color.Red, 5); // default color
                                           //l.DrawEllipse(p, 0, 0, width, height);



            float xAxis = width / 7;
            float yAxis = height / 6;
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {                    
                    int startX = (int)Math.Round(x * xAxis);
                    int startY = (int)Math.Round(y * yAxis);
                    /*int endX = (int)Math.Round(((x+1) * xAxis));
                    int endY = (int)Math.Round((y+1) * xAxis);*/

                    l.DrawRectangle(p,startX, startY, xAxis, yAxis);




                }
            }
















        }// End of draw() 
        //==========================================================================================




        //==========================================================================================
    }// End of Class.
}
