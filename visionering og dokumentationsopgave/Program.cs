//VersionControll_Application:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string input = "";
            QuestionsSettings question = new QuestionsSettings();
            Score leaderboard = new Score();

            //Indicates start game
            while (loop == true)
            {
                Console.WriteLine("Press 1 to play.");
                Console.WriteLine("Press 2 to view leaderboard.");
                Console.WriteLine("Press 3 to exit.");
                input = Console.ReadLine();

                if (input == "1")
                {   
                    question.SelectQuestions();
                }

                if (input == "2")
                {
                    leaderboard.Scoreboard();
                }

                if (input == "3")
                {
                    loop = false;
                }

            }

        }
    }
}
