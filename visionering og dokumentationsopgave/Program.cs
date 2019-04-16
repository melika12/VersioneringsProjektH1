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
            double score = 00.00;
            QuestionsSettings question = new QuestionsSettings();

            while (loop == true)
            {
                Console.WriteLine("Press 1 to play.");
                Console.WriteLine("Press 2 to exit.");
                input = Console.ReadLine();
                int i = 0;
                while (i < 20)
                {
                    if (input == "1")
                    {
                        score = question.SelectQuestions(score);
                    }

                    if (input == "2")
                    {
                        loop = false;
                    }
                    i++;
                }

            }

        }
    }
    class QuestionsSettings
    {
        bool answer;
        public double SelectQuestions(double score)
        {
            Questions newQuestion = new Questions();
            


            int x = 19;
            Random random = new Random();
            
            int randomNumber = random.Next(0, x);
            string randNum = Convert.ToString(randomNumber);


            switch (randNum)
            {
                case "0":
                    answer = newQuestion.Question1();
                    break;
                case "1":
                    answer = newQuestion.Question2();
                    break;
                case "2":
                    answer = newQuestion.Question3();
                    break;
                case "3":
                    answer = newQuestion.Question4();
                    break;
                case "4":
                    answer = newQuestion.Question5();
                    break;
                case "5":
                    answer = newQuestion.Question6();
                    break;
                case "6":
                    answer = newQuestion.Question7();
                    break;
                case "7":
                    answer = newQuestion.Question8();
                    break;
                case "8":
                    answer = newQuestion.Question9();
                    break;
                case "9":
                    answer = newQuestion.Question10();
                    break;
                case "10":
                    answer = newQuestion.Question10();
                    break;
                case "11":
                    answer = newQuestion.Question11();
                    break;
                case "12":
                    answer = newQuestion.Question12();
                    break;
                case "13":
                    answer = newQuestion.Question13();
                    break;
                case "14":
                    answer = newQuestion.Question14();
                    break;
                case "15":
                    answer = newQuestion.Question15();
                    break;
                case "16":
                    answer = newQuestion.Question16();
                    break;
                case "17":
                    answer = newQuestion.Question17();
                    break;
                case "18":
                    answer = newQuestion.Question18();
                    break;
                case "19":
                    answer = newQuestion.Question19();
                    break;

                default:
                    break;
            }

            double new_score = IsCorrect(answer, score);

            return new_score;

        }

        public double IsCorrect(bool a, double score)
        {
            double new_score = 00.00;

            if (a == true)
            {
                Console.WriteLine("That is correct");
                new_score = score + 1;
                Console.WriteLine("Your current total is " + new_score);
            }
            else
            {
                Console.WriteLine("That is not correct.");
                Console.WriteLine("Your score has been reset. Your score was " + score);
            }

            return new_score;
        }
    }
}
