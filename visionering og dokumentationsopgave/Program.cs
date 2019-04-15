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
            string tast = "";
            double score = 00.00;
            Questions question = new Questions();

            while (loop == true)
            {
                Console.WriteLine("Press 1 to play.");
                Console.WriteLine("Press 2 to exit.");
                tast = Console.ReadLine();

                int i = 0;
                while (i < 10)

                {
                    if (tast == "1")
                    {
                        score = question.selectQuestions(score);
                    }

                    if (tast == "2")

                    {
                     loop = false;
                    }
                    i++;
                }
            }

        }
    }
    class Questions
    {
        bool svar;
        public double selectQuestions(double score)
        {
            int x = 4;
            Random random = new Random();

            int randomNumber = random.Next(0, x);
            string randNum = Convert.ToString(randomNumber);


            switch (randNum)
            {
                case "0":
                    svar = questionOne();
                    break;
                case "1":
                    svar = questionTwo();
                    break;
                case "2":
                    svar = questionThree();
                    break;
                case "3":
                    svar = questionFour();
                    break;
                case "4":
                    svar = questionFive();
                    break;

                default:
                    break;
            }

            double new_score = isCorrect(svar, score);

            return new_score;

        }

        public double isCorrect(bool a, double score)
        {
            double new_score = 00.00;

            if (a == true)
            {
                Console.WriteLine("That is correct");
                new_score = score + 1000.01;
                Console.WriteLine("Your current total is " + new_score);
            }
            else
            {
                Console.WriteLine("That is not correct.");
                Console.WriteLine("Your score have been reset. Your score was " + score);
            }

            return new_score;
        }

        public bool questionOne()
        {
            bool svar = false;
            string tast = "";
            Console.WriteLine("What got the largest gravitational pull?");
            Console.WriteLine("");
            Console.WriteLine("A - The Sun");
            Console.WriteLine("B - A black hole");
            Console.WriteLine("C - Yo mama");
            tast = Console.ReadLine();

            if (tast.ToLower() == "b")
            {
                svar = true;
            }

            return svar;
        }

        public bool questionTwo()
        {
            bool svar = false;
            string tast = "";
            Console.WriteLine("Which year is it 2 years after, 4 years before?");
            Console.WriteLine("");
            Console.WriteLine("A - 2015");
            Console.WriteLine("B - 2019");
            Console.WriteLine("C - 2017");
            tast = Console.ReadLine();

            if (tast.ToLower() == "c")
            {
                svar = true;
            }

            return svar;
        }


        public bool questionThree()
        {
            bool svar = false;
            string tast = "";
            Console.WriteLine("Who is the president of the United States?");
            Console.WriteLine("");
            Console.WriteLine("A - Donald Trump");
            Console.WriteLine("B - Barack Obama");
            Console.WriteLine("C - Hillary Clinton");
            tast = Console.ReadLine();

            if (tast.ToLower() == "a")
            {
                svar = true;
            }

            return svar;
        }

        public bool questionFour()
        {
            bool svar = false;
            string tast = "";
            Console.WriteLine("Do Multiverses exist?");
            Console.WriteLine("");
            Console.WriteLine("A - Maybe");
            Console.WriteLine("B - Yes");
            Console.WriteLine("C - Only in fiction");
            tast = Console.ReadLine();

            svar = true;
            return svar;
        }

        public bool questionFive()
        {
            bool svar = false;
            string tast = "";
            Console.WriteLine("Which Traditional beloved Disney movie?");
            Console.WriteLine("");
            Console.WriteLine("A - The Jungle Book");
            Console.WriteLine("B - Beauty and the Beast");
            Console.WriteLine("C - The Lion King");
            tast = Console.ReadLine();

            if (tast.ToLower() == "c")
            {
                svar = true;
            }

            return svar;
        }
    }
}
