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
    public partial class Form1 : Form
    {
        //Connect4 currentGame;
        List<Player> _players;
        
        
        
        
        
        
        
        
        
        //==========================================================================================
        public Form1()
        {
            InitializeComponent();
            _players = new List<Player>();
            





        }//End of Form1 Constructor=================================================================

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

            countLabel.Text = "Player( " + _players.Count.ToString() + " )";


        }//Add of addPlayerButton===================================================================

        private void playButton_Click(object sender, EventArgs e)
        {
            Form gameboard = new GameBoard(_players);
            gameboard.Show();
        }
    }//End of Class=================================================================================
}
