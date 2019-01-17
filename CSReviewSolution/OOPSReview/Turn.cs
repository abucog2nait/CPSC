using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    class Turn
    {
        public static void Play()
        {
            Die PlayerOneDie = new Die();
            Die PlayerTwoDie = new Die();

            int playerOne, playerTwo;

            playerOne = PlayerOneDie.FaceValue;
            playerTwo = PlayerTwoDie.FaceValue;

            Console.WriteLine("Player one rolled a {0}, Player two rolled {1}.", playerOne, playerTwo);
        }
        

    }
}
