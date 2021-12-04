﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectX
{
    public class Player
    {
        private string playerName;
        private static char currentCharacter = (char)1;
        private char playerCharacter;
        private string playerColour;


        //==========================================================================================
        public Player(string name, string colour)
        {
            playerName = name;
            playerColour = colour;
            playerCharacter = currentCharacter++;


            
        }//End of Player.
        //==========================================================================================

        //==========================================================================================
        public char getPlayerChar()
        {
            return playerCharacter;
        }
        //==========================================================================================

        //==========================================================================================
        public string getPlayerName()
        {
            return playerName;
        }
        //==========================================================================================

    }// End of Class.
    //=============================================================================================
}//#################################################################################################
