using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Match
{
    public class Match
    {
        public delegate void FightDisplayDelegate(Boxer boxerOne, Boxer boxerTwo, string punch, int punchDamage);
        public delegate void WinnerDisplayDelegate(Boxer boxerOne, Boxer boxerTwo, int thrownPunches);

        
        public event FightDisplayDelegate displayFightHandler;
        public event WinnerDisplayDelegate displayWinnerHandler;


        public int randomNum()
        {
            return new Random().Next(0, 4);
        }

        public void fightLogic(Boxer playerOne, Boxer playerTwo, string punch)
        {
            int punchStrength = 0;
            int agility = 0;
            int punchDamage = 0;
            Random random = new Random();

            if (playerOne.activePlayer == true)
            {
                punchStrength = playerOne.Strength[punch];
                agility = random.Next(0, playerTwo.Agility[punch] + 1);
                if (punchStrength > agility)
                {
                    punchDamage = punchStrength - agility;
                    playerTwo.Hitpoints -= punchDamage;
                    HitHappend(playerOne, playerTwo, punch, punchDamage);

                }
                playerOne.activePlayer = false;
                playerTwo.activePlayer = true;
            }
            else if (playerTwo.activePlayer == true)
            {
                punchStrength = playerTwo.Strength[punch];
                agility = random.Next(0, playerOne.Agility[punch] + 1);
                if (punchStrength > agility)
                {
                    punchDamage = punchStrength - agility;
                    playerOne.Hitpoints -= punchDamage;
                    HitHappend(playerOne, playerTwo, punch, punchDamage);
                }
                playerOne.activePlayer = true;
                playerTwo.activePlayer = false;
            }
        }

        public void startFight(Boxer playerOne, Boxer playerTwo)
        {
            playerOne.activePlayer = true;
            playerTwo.activePlayer = false;
            int thrownPunches = 50;

            while (playerOne.Hitpoints > 0 && playerTwo.Hitpoints > 0 && thrownPunches > 0 )
            {
                switch (randomNum())
                {
                    case 0:
                        {
                            fightLogic(playerOne, playerTwo, "Cross");
                            thrownPunches -= 1;
                            break;
                        }

                    case 1:
                        {
                            fightLogic(playerOne, playerTwo, "Jab");
                            thrownPunches -= 1;
                            break;
                        }
                    case 2:
                        {
                            fightLogic(playerOne, playerTwo, "Uppercut");
                            thrownPunches -= 1;
                            break;
                        }
                    case 3:
                        {
                            fightLogic(playerOne, playerTwo, "Hook");
                            thrownPunches -= 1;
                            break;
                        }
                      
                    default:
                        Console.WriteLine("lol");
                        break;
                }

            }


            playerWins(playerOne, playerTwo, thrownPunches);

        }

        protected void HitHappend (Boxer playerOne, Boxer playerTwo, string punch, int punchDamage)
        {
            displayFightHandler?.Invoke(playerOne, playerTwo, punch, punchDamage);
        }

        protected void playerWins (Boxer playerOne, Boxer playerTwo, int thrownPunches)
        {
            displayWinnerHandler?.Invoke(playerOne, playerTwo, thrownPunches);
        }
    }
}
