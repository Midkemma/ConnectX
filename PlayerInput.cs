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
    public partial class PlayerInput : Form
    {








        //==========================================================================================
        public PlayerInput()
        {
            InitializeComponent();
        }//End of PlayerInput Constructor===========================================================
        //==========================================================================================



        //==========================================================================================
        public string getName()
        {
            return playerNameTextBox.Text;
        }//End of getName===========================================================================
        //==========================================================================================




        //==========================================================================================
        public string getColour()
        {
            return playerColourTextBox.Text;
        }//End of 
        //==========================================================================================











    }//End of PlayerInput Class=====================================================================
}//#################################################################################################
