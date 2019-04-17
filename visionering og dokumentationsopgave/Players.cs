using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Players
    {
        public string Player(string a, string b)
        {
            string StartingPlayer = "";
            string playerturnOne = a;
            string playerturnTwo = b;

            QuestionsSettings question = new QuestionsSettings();


            Console.WriteLine("Random player starts");
            Random randomStart = new Random();
            int randomPlayer = randomStart.Next(0, 1);

            switch (randomPlayer)
            {
                case 0:
                    Console.WriteLine(playerturnOne + " " + "Starts the game");
                    StartingPlayer = playerturnOne;
                    break;
                case 1:
                    Console.WriteLine(playerturnTwo + " " + "Starts the game");
                    StartingPlayer = playerturnTwo;
                    break;
            }







            return StartingPlayer;
        }
    }
}
