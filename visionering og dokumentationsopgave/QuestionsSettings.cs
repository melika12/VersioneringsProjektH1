﻿using System;
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

            while (true)
            {
                while (d != x)
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;
                   string Timer = Countdowntimer();
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
                                    easyQuestion.Questionseasy(randomquest);
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
                                    mediumQuestion.Questionsmedium(randomquest);
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
                                    hardQuestion.Questionshard(randomquest);
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
            }
        }

        public void IsCorrect(bool a)
        {
            if (a == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That is correct");
                Console.WriteLine("Your current total is ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not correct.");
                Console.ResetColor();
            }
        }
        public string percentage(int i)
        {
            string percent = "You have made it through ";
            int a = 5;
            int b = a * i;
            percent = percent + b + "% of the game";
            return percent;
        }
        public string Countdowntimer()
        {
            int timer = 1;

            int sec = timer * 60;
            Console.CursorVisible = false;
            var daytime = new DateTime(2000, 1, 1, 0, timer, 0);

            for (int i = 0; i <= timer * 60; i++, sec--)
            {
                //timer = timer * 60;

                if (sec <= 60 && sec >= 31)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else if (sec <= 30 && sec >= 11)
                {

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }

                else if (sec <= 10 && sec >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(daytime.ToString("mm:ss"));
                daytime = daytime.AddSeconds(-1);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            return daytime.ToString("mm:ss");
        }
    }
}


