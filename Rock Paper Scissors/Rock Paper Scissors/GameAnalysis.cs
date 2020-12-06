using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class GameAnalysis: Game
    {
        // function to count how many times a move is made
        public static void MostUsedMove(string playerWeapon, string aiWeapon)
        {
            if (playerWeapon.Equals("rock"))
            {
                rockCounter += 1;
            }

            if (aiWeapon.Equals("rock"))
            {
                rockCounter += 1;
            }

            if (playerWeapon.Equals("paper"))
            {
                paperCounter += 1;
            }

            if (aiWeapon.Equals("paper"))
            {
                paperCounter += 1;
            }

            if (playerWeapon.Equals("scissors"))
            {
                scissorsCounter += 1;
            }

            if (aiWeapon.Equals("scissors"))
            {
                scissorsCounter += 1;
            }
        }

    }
}
