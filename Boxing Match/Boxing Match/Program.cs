using System;
using System.Collections.Generic;

namespace Boxing_Match
{
    class Program
    {


        static void Main(string[] args)
        {

        Boxer BoxerOne = new Boxer(" Andy Ruiz Jr", 128, 1000, new Dictionary<string, int>() {
        { "Cross", 26 },
        { "Jab", 16 },
        { "Uppercut", 21 },
        { "Hook", 16 },
        }, new Dictionary<string, int>() {
        { "Cross", 26 },
        { "Jab", 26 },
        { "Uppercut", 16 },
        { "Hook", 21 },
        });

        Boxer BoxerTwo = new Boxer("Tyson Fury", 124, 1500, new Dictionary<string, int>() {
        { "Cross", 20 },
        { "Jab", 10 },
        { "Uppercut", 25 },
        { "Hook", 20 },
        }, new Dictionary<string, int>() {
        { "Cross", 15 },
        { "Jab", 15 },
        { "Uppercut", 30 },
        { "Hook", 15 },
        });

            Match start = new Match();
            Display display = new Display();

            start.displayFightHandler += display.ShowHitMessage;
            start.displayWinnerHandler += display.ShowWinMessage;

            start.startFight(BoxerOne,  BoxerTwo);

            start.displayFightHandler -= display.ShowHitMessage;
            start.displayWinnerHandler -= display.ShowWinMessage;


        }
    }
}
