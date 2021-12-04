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
    public partial class Main_Form : Form
    {
        //Connect4 currentGame;
        List<Player> _players;
        private Connect4 _connect4;
        private int currentPlayer;


        //==========================================================================================
        public Main_Form()
        {
            InitializeComponent();
            _players = new List<Player>();
            _players.Add(new Player("NameA", "Yellow")); //testing user
            _players.Add(new Player("NameB", "Red")); //testing user
            countLabel.Text = $"Current Number of Players = {_players.Count.ToString()}";

        }// End of Form1 Constructor
        //==========================================================================================

        //==========================================================================================
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            PlayerInput _playerInput = new PlayerInput();            
            _playerInput.ShowDialog();
            if(_playerInput.DialogResult == DialogResult.OK)
            {
                string playerName = _playerInput.getName();
                string playerColour = _playerInput.getColour();
                Player player = new Player(playerName, playerColour);
                _players.Add(player);
            }
            countLabel.Text = $"Current Number of Players = {_players.Count.ToString()}";

        }// End of addPlayerButton
        //==========================================================================================

        //==========================================================================================
        private void playButton_Click(object sender, EventArgs e)
        {            
            _connect4 = new Connect4(_players[0], _players[1]);
            currentPlayer = 0;
            gameBoardPanel.Paint += GameBoard_Paint;
            gameBoardPanel.Resize += resizeBoard;
            gameBoardPanel.Click += mousePosOnClick;
            gameBoardPanel.Invalidate();

        } // End of playButton_Click
        //==========================================================================================

        //==========================================================================================
        private void resizeBoard(object sender, EventArgs e)
        {
            gameBoardPanel.Invalidate();
        }// end of resizeBoard
        //==========================================================================================

        //==========================================================================================
        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            int formHeight = gameBoardPanel.Height;
            int formWidth = gameBoardPanel.Width;
            Graphics l = gameBoardPanel.CreateGraphics();
            if(_connect4 !=null)
                _connect4.draw(l, formHeight, formWidth);
            l.Dispose();
        }// end of GameBoard_Paint
        //==========================================================================================


        //==========================================================================================
        private void mousePosOnClick(object sender, EventArgs e)
        {
            MouseEventArgs mEA = (MouseEventArgs)e;
            int boardWidth = gameBoardPanel.Width;
            int _col = _connect4.columCalc(mEA.X, boardWidth);

            //Player counter
            bool result = _connect4.playMove(_col, _players[currentPlayer]);

            //check valid move
            if (result)
            {
                gameBoardPanel.Invalidate();
                if (_connect4.getWin())
                {
                    MessageBox.Show($"Congratulations {_players[currentPlayer].getPlayerName()}.\n" +
                        $" You have won the match! \n Well done!");
                }
                if (currentPlayer == _players.Count - 1)
                {
                    currentPlayer = 0;
                }
                else currentPlayer++;
            }
        }// end of mousePosOnClick
        //==========================================================================================


    }//End of Class=================================================================================
}//#################################################################################################
