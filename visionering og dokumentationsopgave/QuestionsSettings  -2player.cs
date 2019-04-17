using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class QuestionsSettings2
    {
        public void SelectQuestions2()
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

            Players newplayer = new Players();
            

            Console.WriteLine("Please enter playernames");
            Console.WriteLine("PlayersOne");
            string player1 = Console.ReadLine();
            Console.WriteLine("PlayerTwo");
            string player2 = Console.ReadLine();
            string startingPlayer = newplayer.Player(player1, player2);
            string playerturn;
            playerturn = startingPlayer;


            while (d != x)
            {
                if (playerturn == player1)
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
                                    Console.WriteLine(player1 + "'s turn!");
                                    easyQuestion.Questionseasy(randomquest);
                                    numbTakeneasy[a] = randomquest;
                                    d++;
                                    string percent1 = percentage(d);
                                    Console.WriteLine(percent1);
                                    a++;
                                    playerturn = player2;
                                    break;
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
                                    playerturn = player2;
                                    break;
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
                                    playerturn = player2;
                                    break;
                                }
                            }
                            break;
                        default:
                            break;

                    }

                    
                }
                else if (playerturn == player2)
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
                                    Console.WriteLine(player2 + "'s turn!");
                                    easyQuestion.Questionseasy(randomquest);
                                    numbTakeneasy[a] = randomquest;
                                    d++;
                                    string percent1 = percentage(d);
                                    Console.WriteLine(percent1);
                                    a++;
                                    playerturn = player1;
                                    break;
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
                                    playerturn = player1;
                                    break;
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
                                    playerturn = player1;
                                    break;
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
    }
}


