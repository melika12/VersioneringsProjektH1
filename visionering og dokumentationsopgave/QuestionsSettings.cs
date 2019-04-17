using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class QuestionsSettings
    {
        public void SelectQuestions()
        {
            Easy easyQuestion = new Easy();
            Medium mediumQuestion = new Medium();
            Hard hardQuestion = new Hard();
            int x = 20;
            int y = 2;
            int d = 0;
            Random randomMode = new Random();
            Random randomQuestion = new Random();

            int[] numbTakeneasy = new int[x];
            int[] numbTakenmedium = new int[x];
            int[] numbTakenhard = new int[x];

            double score = 0.00;
            Score points = new Score();

                while (d != x)
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;

                    int randommod = randomMode.Next(0, y);
                    int randomquest = randomQuestion.Next(0, x);

                    switch (randommod)
                    {
                        case 0:
                            int k = 0;
                            while (k <= x)
                            {
                                if (numbTakeneasy.Contains(randomquest))
                                {
                                    k++;
                                }
                                else
                                {
                                    score = IsCorrect(easyQuestion.Questionseasy(randomquest), "easy", score);
                                    numbTakeneasy[a] = randomquest;
                                    d++;
                                    string percent1 = percentage(d);
                                    Console.WriteLine(percent1);
                                    a++;
                                }
                            }

                            break;
                        case 1:
                            int l = 0;
                            while (l <= x)
                            {
                                if (numbTakenmedium.Contains(randomquest))
                                {
                                    l++;
                                }
                                else
                                {
                                    score = IsCorrect(mediumQuestion.Questionsmedium(randomquest), "medium", score);
                                    numbTakenmedium[b] = randomquest;
                                    d++;
                                    string percent1 = percentage(d);
                                    Console.WriteLine(percent1);
                                    b++;
                                }
                            }
                            break;
                        case 2:
                            int g = 0;
                            while (g <= x)
                            {
                                if (numbTakenhard.Contains(randomquest))
                                {
                                    g++;
                                }
                                else
                                {
                                    score = IsCorrect(hardQuestion.Questionshard(randomquest), "hard", score);
                                    numbTakenhard[c] = randomquest;
                                    d++;
                                    string percent1 = percentage(d);
                                    Console.WriteLine(percent1);
                                    c++;
                                }
                            }
                            break;
                        default:
                            break;

                    }


                    

                }
            points.Highscore(score);



        }

        public double IsCorrect(bool a, string difficulty, double score)
        {
            double new_score;
            Score points = new Score();
            if (a == true)
            {
                Console.WriteLine("\a");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That is correct");
                new_score = points.Points(score, difficulty);
                Console.WriteLine("Your current total is " + new_score);
                Console.ResetColor();                
            }
            else
            {
                Console.Beep(235, 1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not correct.");
                Console.ResetColor();
                new_score = score;
            }

            return new_score;
        }
        public string percentage(int c)
        {
            string percent = "You have made it through ";
            int a = 5;
            int b = a * c;
            percent = percent + b + "% of the game";
            return percent;
        }
        
    }
}

    
