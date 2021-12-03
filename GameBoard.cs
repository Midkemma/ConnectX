using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectX
{
    public partial class GameBoard : Form
    {
        private List<Player> _players;
        private Connect4 _connect4;
        private int currentPlayer;



        //==========================================================================================
        private GameBoard()
        {
            InitializeComponent();
            
        } //End of GameBoard(empty) constructor
        //==========================================================================================

        //==========================================================================================
        public GameBoard(List<Player> players)
        {
            InitializeComponent();
            _players = players;
            _players.Add(new Player("NameA", "Yellow")); //testing user
            _players.Add(new Player("NameB", "Red")); //testing user
            _connect4 = new Connect4(_players[0], _players[1]);
            currentPlayer = 0;

            boardPanel.Paint += GameBoard_Paint;
            boardPanel.Resize += resizeBoard;
            boardPanel.Click += mousePosOnClick;
            




        } //End of GameBoard Constructor
        //==========================================================================================

        //==========================================================================================
        private void resizeBoard(object sender, EventArgs e)
        {
            boardPanel.Invalidate();
        }// end of resizeBoard
         //==========================================================================================

        //==========================================================================================
        private void mousePosOnClick(object sender, EventArgs e)
        {
            MouseEventArgs mEA = (MouseEventArgs)e;
            int boardWidth = boardPanel.Width;
            int _col = _connect4.columCalc(mEA.X, boardWidth);

            //Player counter
            bool result = _connect4.playMove(_col, _players[currentPlayer]);

            //check valid move
            if (result) 
            {
                boardPanel.Invalidate();
                if (_connect4.getWin())
                {
                    MessageBox.Show($"Congratulations player {currentPlayer}, you have won!");
                }
                if (currentPlayer == _players.Count - 1)    
                {
                    currentPlayer = 0;
                } else currentPlayer++;
            }
            

        }// end of mousePosOnClick
        //==========================================================================================

        //==========================================================================================
        //==========================================================================================

        //==========================================================================================
        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            int formHeight = boardPanel.Height;
            int formWidth = boardPanel.Width;
            Graphics l = boardPanel.CreateGraphics();
            //l.DrawEllipse(p, 50, 50, 200, 200);
            _connect4.draw(l, formHeight, formWidth);
            playerTurnLabel.Text = $"Player Turn : {_players[currentPlayer].getPlayerName()}";



            l.Dispose();
        }// end of GameBoard_Paint
         //=========================================================================================








    } // End of GameBoard class
    //==============================================================================================
}//#################################################################################################
