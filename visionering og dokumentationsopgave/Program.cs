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
            string input1 = "";
            double score = 00.00;
            QuestionsSettings question = new QuestionsSettings();

            while (loop == true)
            {
                Console.WriteLine("Press 1 to play.");
                Console.WriteLine("Press 2 to exit.");
                input = Console.ReadLine();
                
                    if (input == "1")
                    {
                        Console.WriteLine("Press 1 for easy");
                        Console.WriteLine("Press 2 for medium");
                        Console.WriteLine("Press 3 for hard");
                        input1 = Console.ReadLine();
                    }

                    if (input == "2")
                    {
                        loop = false;
                        break;
                    }
                int i = 0;
                while (i < 19)
                {
                    if (input1 == "1")
                    {
                        score = question.QuestionsEasy(score);
                    }
                    if (input1 == "2")
                    {
                        score = question.QuestionsMedium(score);
                    }
                    if (input1 == "3")
                    {
                        score = question.QuestionsHard(score);
                    }
                }

            }

        }
    }
    class QuestionsSettings
    {
        bool answer;
        public double QuestionsEasy(double score)
        {
            Easy newEasy = new Easy();
            
            int x = 19;
            Random random = new Random();
            
            int randomNumber = random.Next(0, x);
            string randNum = Convert.ToString(randomNumber);


            switch (randNum)
            {
                case "0":
                    answer = newEasy.Question1();
                    break;
                case "1":
                    answer = newEasy.Question2();
                    break;
                case "2":
                    answer = newEasy.Question3();
                    break;
                case "3":
                    answer = newEasy.Question4();
                    break;
                case "4":
                    answer = newEasy.Question5();
                    break;
                case "5":
                    answer = newEasy.Question6();
                    break;
                case "6":
                    answer = newEasy.Question7();
                    break;
                case "7":
                    answer = newEasy.Question8();
                    break;
                case "8":
                    answer = newEasy.Question9();
                    break;
                case "9":
                    answer = newEasy.Question10();
                    break;
                case "10":
                    answer = newEasy.Question10();
                    break;
                case "11":
                    answer = newEasy.Question11();
                    break;
                case "12":
                    answer = newEasy.Question12();
                    break;
                case "13":
                    answer = newEasy.Question13();
                    break;
                case "14":
                    answer = newEasy.Question14();
                    break;
                case "15":
                    answer = newEasy.Question15();
                    break;
                case "16":
                    answer = newEasy.Question16();
                    break;
                case "17":
                    answer = newEasy.Question17();
                    break;
                case "18":
                    answer = newEasy.Question18();
                    break;
                case "19":
                    answer = newEasy.Question19();
                    break;

                default:
                    break;
            }

            double new_score = IsCorrect(answer, score);

            return new_score;

        }

        public double QuestionsMedium(double score)
        {
            Medium newMedium = new Medium();

            int x = 19;
            Random random = new Random();

            int randomNumber = random.Next(0, x);
            string randNum = Convert.ToString(randomNumber);


            switch (randNum)
            {
                case "0":
                    answer = newMedium.Question1();
                    break;
                case "1":
                    answer = newMedium.Question2();
                    break;
                case "2":
                    answer = newMedium.Question3();
                    break;
                case "3":
                    answer = newMedium.Question4();
                    break;
                case "4":
                    answer = newMedium.Question5();
                    break;
                case "5":
                    answer = newMedium.Question6();
                    break;
                case "6":
                    answer = newMedium.Question7();
                    break;
                case "7":
                    answer = newMedium.Question8();
                    break;
                case "8":
                    answer = newMedium.Question9();
                    break;
                case "9":
                    answer = newMedium.Question10();
                    break;
                case "10":
                    answer = newMedium.Question10();
                    break;
                case "11":
                    answer = newMedium.Question11();
                    break;
                case "12":
                    answer = newMedium.Question12();
                    break;
                case "13":
                    answer = newMedium.Question13();
                    break;
                case "14":
                    answer = newMedium.Question14();
                    break;
                case "15":
                    answer = newMedium.Question15();
                    break;
                case "16":
                    answer = newMedium.Question16();
                    break;
                case "17":
                    answer = newMedium.Question17();
                    break;
                case "18":
                    answer = newMedium.Question18();
                    break;
                case "19":
                    answer = newMedium.Question19();
                    break;

                default:
                    break;
            }

            double new_score = IsCorrect(answer, score);

            return new_score;

        }

        public double QuestionsHard(double score)
        {
            Hard newHard = new Hard();

            int x = 19;
            Random random = new Random();

            int randomNumber = random.Next(0, x);
            string randNum = Convert.ToString(randomNumber);


            switch (randNum)
            {
                case "0":
                    answer = newHard.Question1();
                    break;
                case "1":
                    answer = newHard.Question2();
                    break;
                case "2":
                    answer = newHard.Question3();
                    break;
                case "3":
                    answer = newHard.Question4();
                    break;
                case "4":
                    answer = newHard.Question5();
                    break;
                case "5":
                    answer = newHard.Question6();
                    break;
                case "6":
                    answer = newHard.Question7();
                    break;
                case "7":
                    answer = newHard.Question8();
                    break;
                case "8":
                    answer = newHard.Question9();
                    break;
                case "9":
                    answer = newHard.Question10();
                    break;
                case "10":
                    answer = newHard.Question10();
                    break;
                case "11":
                    answer = newHard.Question11();
                    break;
                case "12":
                    answer = newHard.Question12();
                    break;
                case "13":
                    answer = newHard.Question13();
                    break;
                case "14":
                    answer = newHard.Question14();
                    break;
                case "15":
                    answer = newHard.Question15();
                    break;
                case "16":
                    answer = newHard.Question16();
                    break;
                case "17":
                    answer = newHard.Question17();
                    break;
                case "18":
                    answer = newHard.Question18();
                    break;
                case "19":
                    answer = newHard.Question19();
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
