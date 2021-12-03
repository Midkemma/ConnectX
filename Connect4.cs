using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectX
{
    class Connect4
    {
        //2D array for board.
        private char[,] _gameBoard;
        //List of player.
        List<Player> _players;
        //bool to see if the winCondition has been met
        private bool winConditionMet;

        





        //==========================================================================================
        public Connect4(Player playerA, Player playerB)
        {
            _gameBoard = new char[7, 6];
            //_gameBoard[3, 0] = (char)1;
            //_gameBoard[2, 0] = (char)2;
            _players = new List<Player>();
            //Add at least 2 players to Player list
            _players.Add(playerA);
            _players.Add(playerB);
            winConditionMet = false;





        }// End of Constructor.
        //==========================================================================================

        //==========================================================================================
        //==========================================================================================


        //==========================================================================================
        public void draw(Graphics l, int height, int width)
        {
            Pen p = new Pen(Color.Black, 5); // default color
                                           //l.DrawEllipse(p, 0, 0, width, height);



            float xAxis = width / 7;
            float yAxis = height / 6;
            for (int x = 0; x < 7; x++)
            {
                for (int y = (6-1); y >= 0; y--)
                //for (int y = 0; y < 6; y++)
                {                    
                    int startX = (int)Math.Round(x * xAxis);
                    int startY = (int)Math.Round(y * yAxis);
                    /*int endX = (int)Math.Round(((x+1) * xAxis));
                    int endY = (int)Math.Round((y+1) * xAxis);*/
                    l.DrawRectangle(p,startX, startY, xAxis, yAxis);
                    //------------------------------------------------------------------------------
                    //This switch case is to draw the Connect 4 chips in the _gameBoard array
                    switch (_gameBoard[x, y])
                    {
                        case (char)0:
                            break;
                        case (char)1:
                            System.Drawing.SolidBrush myBrush = 
                                new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
                            l.FillEllipse(myBrush, startX, startY, xAxis, yAxis);
                            break;
                        case (char)2:
                            myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                            l.FillEllipse(myBrush, startX, startY, xAxis, yAxis);
                            break;
                        default:
                            break;
                    }
                    //------------------------------------------------------------------------------
                }
            }


        }// End of draw() 
        //==========================================================================================

        //==========================================================================================
        public bool playMove(int _col, Player player)
        {
            if (_gameBoard[_col, 0] == 0)
            {
                _gameBoard[_col, 0] = player.getPlayerChar();

                int xPos = _col;
                int yPos = 0;
                
                int whileCount = 1;
                while (whileCount < 6 && _gameBoard[_col,whileCount] == 0)
                {
                    //MessageBox.Show($"Col = {_col} \n Y pos = {whileCount}");
                    _gameBoard[_col, whileCount - 1] = (char)0;
                    _gameBoard[_col, whileCount] = player.getPlayerChar();                    
                    yPos = whileCount;
                    whileCount++;

                }
                winConditionMet = hasCurrentPlayerWon(player, xPos, yPos);              
                return true;
            }
            else return false;
        }
        //==========================================================================================

        //==========================================================================================
        // getGameBoardArrayData(int x, int y)
        // return char from array or (char)0 if outside array
        private char getGameBoardArrayData(int x, int y)
        {
            if (x > 6 || x < 0 || y > 5 || y < 0) // if outside of array
            {
                return (char)0; // return 0 char which is non-player char in array; 
            }
            return _gameBoard[x, y];
        }// End of getGameBoardArrayData(int x, int y)
         //==========================================================================================

        //==========================================================================================
        /// <summary>
        /// check directions to see if there is a sequence chips in a row that meets winCondition.
        /// </summary>
        /// <param name="currentPlayer"></param>
        /// <param name="xPos">x-coordinate to check from</param>
        /// <param name="yPos">y-coordinate to check from</param>
        /// <returns>bool to confirm if player has won or not.</returns>
        private bool hasCurrentPlayerWon(Player currentPlayer, int xPos, int yPos)
        {
            int winCondition = 4;
            // Horizontal Check
            // Set the counter so the players sequence of chips can be counted
            int sequenceCount = 0;
            for (int x = xPos - (winCondition - 1); x < xPos + (winCondition - 1); x++)
            {
                // Char to check
                char currentChar = getGameBoardArrayData(x, yPos);
                if (currentChar == currentPlayer.getPlayerChar())
                {                    
                    sequenceCount += 1; // increase sequence count
                }
                else
                {
                    sequenceCount = 0; // reset sequence count
                }
                if (sequenceCount == winCondition)
                {
                    return true; //hasCurrentPlayerWon is true
                }
            } // End of Horizontal check
            //Vertical Check
            // Set the counter so the players sequence of chips can be counted
            sequenceCount = 0;
            for (int y = yPos - winCondition; y < yPos + winCondition; y++)
            {
                //Char to check
                char currentChar = getGameBoardArrayData(xPos, y);
                if (currentChar == currentPlayer.getPlayerChar())
                {
                    sequenceCount += 1; // increase sequence count
                }
                else
                {
                    sequenceCount = 0; // reset sequence count
                }
                if (sequenceCount == winCondition)
                {
                    return true; //hasCurrentPlayerWon is true
                }
            }// End of Vertical check
            //Backslash Check
            // Set the counter so the players sequence of chips can be counted
            sequenceCount = 0;
            int xVar = xPos - winCondition;
            for (int y = yPos - winCondition; y < yPos + winCondition; y++)
            {
                //Char to check
                char currentChar = getGameBoardArrayData(xVar, y);
                if (currentChar == currentPlayer.getPlayerChar())
                {
                    sequenceCount += 1; // increase sequence count
                }
                else
                {
                    sequenceCount = 0; // reset sequence count
                }
                if (sequenceCount == winCondition)
                {
                    return true; //hasCurrentPlayerWon is true
                }
                ++xVar;
            }// End of Backslash check
            //Forwardslash Check
            // Set the counter so the players sequence of chips can be counted
            sequenceCount = 0;
            xVar = xPos + winCondition;
            for (int y = yPos - winCondition; y < yPos + winCondition; y++)
            {
                //Char to check
                char currentChar = getGameBoardArrayData(xVar, y);
                if (currentChar == currentPlayer.getPlayerChar())
                {
                    sequenceCount += 1; // increase sequence count
                }
                else
                {
                    sequenceCount = 0; // reset sequence count
                }
                if (sequenceCount == winCondition)
                {
                    return true; //hasCurrentPlayerWon is true
                }
                --xVar;
            }
            return false; // hasCurrentPlayerWon hasn't been found to be true so return false
        }// End of hasCurrentPlayerWon
        //==========================================================================================

        //==========================================================================================
        public bool getWin()
        {
            return winConditionMet;
        }//end of getWin
        //==========================================================================================

        //==========================================================================================
        public int columCalc(int xPos,int boardWidth)
        {
             

            return (int)Math.Floor(xPos / (boardWidth / 7.0));
        }
        //==========================================================================================





















        //==========================================================================================
    }// End of Class.
}
