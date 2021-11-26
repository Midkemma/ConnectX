using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectX
{
    class Player
    {
        private string playerName;
        private static char currentCharacter = (char)0;
        private char playerCharacter;
        private string playerColour;










        //==========================================================================================
        public Player(string name, string colour)
        {
            playerName = name;
            playerColour = colour;
            playerCharacter = currentCharacter++;


            //End of Player.
        }//=========================================================================================







        //End of Class.
    }//=============================================================================================
}//#################################################################################################
