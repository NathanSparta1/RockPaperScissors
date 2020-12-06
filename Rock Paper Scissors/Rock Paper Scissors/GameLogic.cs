using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Rock_Paper_Scissors
{
    class GameLogic: Game
    {
        bool hasWon = false;
        bool hasDrawn = false;

        // function that declares how the player can win
        public bool HasWon(string player,string ai)
        {
            if (player.Equals("rock") && ai.Equals("scissors"))
            {
                return true;
            }

            else if(player.Equals("paper") && ai.Equals("rock"))
            {
                return true;
            }

            else if (player.Equals("scissors") && ai.Equals("paper"))
            {
                return true;
            }

            else { return false; }
        }

        // function that declares how the player can draw
        public bool HasDrawn(string player, string ai)
        {
            if (player.Equals(ai))
            {
                return true;
            }
            else return false;
        }
        // function that handles execution of a match
        public void Match()
        {
            string PlayerWeapon = WeaponConfig.SetUserInput();
            PlayerWeapon = WeaponConfig.UserWeaponSelect(PlayerWeapon);
            Thread.Sleep(2000);
            string aiWeapon = WeaponConfig.SetAIWeapon();
            Thread.Sleep(2000);
            GameAnalysis.MostUsedMove(PlayerWeapon, aiWeapon);

            hasWon = HasWon(PlayerWeapon, aiWeapon);
            hasDrawn = HasDrawn(PlayerWeapon, aiWeapon);
        }
        // function that plays match and handles all end gam outcomes
        public void PlayGame()
        {
            rematchCounter = 1;
            Match();
            // If game is drawn player players computer again
            while (hasWon == false && hasDrawn == true)
            {
                Console.WriteLine("Game drawn lets Rematch\n");
                rematchCounter += 1;
                Match();                
            }

            // player win outcome
            if (hasWon == true && hasDrawn == false)
            {
                Console.WriteLine("Congratulations! you beat the computer\n");
                if (rematchCounter > 1)
                {
                    Console.WriteLine("Total games played =" + " " + rematchCounter);
                    Console.WriteLine("Most used moves =" + " " + "Rock" + " " + rockCounter + " " +
                        "Paper" + " " + paperCounter + " " + "Scissors" + " " + scissorsCounter);
                }
            }

            // player lose outcome
            if (hasWon == false && hasDrawn == false)
            {
                Console.WriteLine("You lose, unlucky maybe next time\n");
                if (rematchCounter > 1)
                {
                    Console.WriteLine("Total games played =" + " " + rematchCounter);
                    Console.WriteLine("Most used moves =" + " " + "Rock" + " " + rockCounter + " " +
                            "Paper" + " " + paperCounter + " " + "Scissors" + " " + scissorsCounter);
                }
            }

        }

    }
}
