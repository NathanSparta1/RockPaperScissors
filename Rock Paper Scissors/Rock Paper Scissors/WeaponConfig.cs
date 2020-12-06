using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public class WeaponConfig
    {
        public static string input;
        public static Random rnd = new Random();

        // handles user initial input and corrects it if wrong
        public static string SetUserInput()
        {          
            Console.WriteLine("Select Rock, Paper or Scissors");
            input = Console.ReadLine().ToLower();
            while (true)
            {
                if (input.Equals("rock") == true)
                    break;
                if (input.Equals("paper") == true)
                    break;
                if (input.Equals("scissors") == true)
                    break;

                Console.WriteLine("Only enter rock, paper or scissors, try again...");
                input = Console.ReadLine().ToLower();
            }
            return input;
        }

        // sets user input to either rock, paper or scissors
        public static string UserWeaponSelect(string userWeapon)
        {            

            switch (userWeapon)
            {
                case "rock":
                    Console.WriteLine("You selected Rock");
                    userWeapon = "rock";
                    return userWeapon;

                case "paper":
                    Console.WriteLine("You Selected Paper");
                    userWeapon = "paper";
                    return userWeapon;

                case "scissors":
                    Console.WriteLine("You selected Scissors");
                    userWeapon = "scissors";
                    return userWeapon;
                    
                default:
                    userWeapon = string.Empty;
                    return userWeapon;
            }
            
        }
        
        // set weapon of the ai via a random number 1 to 3
        public static string SetAIWeapon()
        {
            
            int rndNum = rnd.Next(0, 3);

            if (rndNum == 0)
            {
                Console.WriteLine("Computer has selected Rock");
                input = "rock";
            }

            else if (rndNum == 1)
            {
                Console.WriteLine("Computer has selected Paper");
                input = "paper";
            }

            else if (rndNum == 2)
            {
                Console.WriteLine("Computer has selected Scissors");
                input = "scissors";
            }

            else 
            {
                Console.WriteLine("Computer has forfeited");
                input = "none"; 
            }

            return input;
        }

    }
}
