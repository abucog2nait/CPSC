using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Turn
    {
        //public static void Play()
        //{
        //MINE 
        //Die PlayerOneDie = new Die();
        //Die PlayerTwoDie = new Die();

        //int playerOne, playerTwo;

        //playerOne = PlayerOneDie.FaceValue;
        //playerTwo = PlayerTwoDie.FaceValue;

        //Console.WriteLine("Player one rolled a {0}, Player two rolled {1}.", playerOne, playerTwo);

        //TEACHERS******

        //}

        public int Player1 { get; set; }
        public int Player2 { get; set; }
        //optionally, for practice only add constructors

        public Turn()
        {

        }

        public Turn(int player1, int player2)
        {
            Player1 = player1;
            Player2 = player2; 
        }
    }
}
