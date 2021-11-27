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
            _players.Add(new Player("NameA", "Red")); //testing user
            _players.Add(new Player("NameB", "Black")); //testing user
            _connect4 = new Connect4(_players[0], _players[1]);


            this.Paint += GameBoard_Paint;






        } //End of GameBoard Constructor
        //==========================================================================================





        //==========================================================================================
        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            int formHeight = this.Height;
            int formWidth = this.Width;

            //this.CreateGraphics().Clear(GameBoard.ActiveForm.BackColor);
            

            Pen p = new Pen(Color.Red, 5); // default color
            Graphics l = e.Graphics;
            //l.DrawEllipse(p, 50, 50, 200, 200);
            _connect4.draw(l, formHeight, formWidth);










            l.Dispose();



        }
        //==========================================================================================





    } // End of GameBoard class
    //==============================================================================================
}//#################################################################################################
