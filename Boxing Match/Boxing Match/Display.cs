using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Boxing_Match
{
    public class Display
    {
        public void ShowHitMessage(Boxer playerOne, Boxer playerTwo, string punch, int punchDamage)
        {
            if( playerOne.activePlayer == true)
            {
                Console.WriteLine("=========================================================================");
                Console.WriteLine($"{playerOne.Name} hit {playerTwo.Name} with {punch}");
                Console.WriteLine($"{playerTwo.Name} took {punchDamage} damage and has {playerTwo.Hitpoints} hitpoints");
                Console.WriteLine("=========================================================================");
            } else
            {
                Console.WriteLine("=========================================================================");
                Console.WriteLine($"{playerTwo.Name} hit {playerOne.Name} with {punch}");
                Console.WriteLine($"{playerOne.Name} took {punchDamage} damage and has {playerOne.Hitpoints} hitpoints");
                Console.WriteLine("=========================================================================");
            }
        }

        public void ShowWinMessage(Boxer playerOne, Boxer playerTwo, int thrownPunches)
        {
            if (playerOne.Hitpoints < 0)
            {
                Console.WriteLine($"{ playerTwo.Name} wins with knockout");
            }
            else if (playerTwo.Hitpoints < 0)
            {
                Console.WriteLine($"{ playerOne.Name} wins with knockout");
            }
            else if (thrownPunches <= 0)
            {
                if (playerOne.Hitpoints > playerTwo.Hitpoints)
                {
                    Console.WriteLine($"{ playerOne.Name} wins on points");
                }
                else
                {
                    Console.WriteLine($"{ playerTwo.Name} wins on points");
                }
            }
        }
    }
}
