﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Hard
    {
        //Question Section:

        public bool Questionshard(int a)
        {
            bool answer = false;
            string input = "";

            switch (a)
            {
                case 0:
                    Console.WriteLine("Which year did the first man walk the moon?");
                    Console.WriteLine("");
                    Console.WriteLine("A - 1969");
                    Console.WriteLine("B - 1971");
                    Console.WriteLine("C - It's fake");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 1:
                    Console.WriteLine("How many minutes is a day longer on Mars than on Earth?");
                    Console.WriteLine("");
                    Console.WriteLine("A - 205 min.");
                    Console.WriteLine("B - 20 min.");
                    Console.WriteLine("C - 40 min.");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 2:
                    Console.WriteLine("How many planets is Earth away from the Sun?");
                    Console.WriteLine("");
                    Console.WriteLine("A - 5");
                    Console.WriteLine("B - 7");
                    Console.WriteLine("C - 3");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 3:
                    Console.WriteLine("Who died first of the german generals in World War II?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Günther von Kluge");
                    Console.WriteLine("B - Paul Ludwig Ewald von Kleist");
                    Console.WriteLine("C - Heinrich Himmler");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 4:
                    Console.WriteLine("Which food company was the second biggest in the world in 2018?");
                    Console.WriteLine("");
                    Console.WriteLine("A - McDonald's");
                    Console.WriteLine("B - Nestle");
                    Console.WriteLine("C - Cargill");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 5:
                    Console.WriteLine("Who is the world's highest-paid actor in the world in 2018?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Dwayne 'The Rock' Johnson");
                    Console.WriteLine("B - Robert Downey Jr.");
                    Console.WriteLine("C - George Clooney");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 6:
                    Console.WriteLine("How many decimals has been found in pi?");
                    Console.WriteLine("");
                    Console.WriteLine("A - 2.7 trillion digits");
                    Console.WriteLine("B - 22 trillion digits");
                    Console.WriteLine("C - 31.4 trillion digits");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 7:
                    Console.WriteLine("How many legs does a millipede have?");
                    Console.WriteLine("");
                    Console.WriteLine("A - 1000 of course");
                    Console.WriteLine("B - Around 500 at most");
                    Console.WriteLine("C - The record is at 750");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 8:
                    Console.WriteLine("At the beginning of the 1990s which country had the most camels?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Somalia");
                    Console.WriteLine("B - Kenya");
                    Console.WriteLine("C - Niger");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 9:
                    Console.WriteLine("What is illegal to duel with in Massachusetts?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Machetes");
                    Console.WriteLine("B - Spears");
                    Console.WriteLine("C - Water Pistols");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 10:
                    Console.WriteLine("What can you become licensed to in Texas for 150$?");
                    Console.WriteLine("");
                    Console.WriteLine("A - A roughnech");
                    Console.WriteLine("B - A dead animal hunter");
                    Console.WriteLine("C - A animal hunter");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 11:
                    Console.WriteLine("What does people produce more of when they are frightened?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Sweat");
                    Console.WriteLine("B - Spit");
                    Console.WriteLine("C - Earwax");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 12:
                    Console.WriteLine("What did The Emperor Claudius legalize at banquets?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Barfing");
                    Console.WriteLine("B - Farting");
                    Console.WriteLine("C - Eating with elbows at the table");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 13:
                    Console.WriteLine("What is banned by law in Japanese restaurants?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Chewing food noisily");
                    Console.WriteLine("B - Water Pistols");
                    Console.WriteLine("C - Tipping");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 14:
                    Console.WriteLine("What does 15% of women on Valentine's Day");
                    Console.WriteLine("");
                    Console.WriteLine("A - Sits in bars, waiting to find someone for the night");
                    Console.WriteLine("B - Bying themselves chocolate");
                    Console.WriteLine("C - Sending themselves flowers");
                    input = Console.ReadLine();
                    if (input.ToLower() == "")
                    {
                        answer = true;
                    }
                    break;
                case 15:
                    Console.WriteLine("Who's fault was it that Santa Claus became red?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Coca cola");
                    Console.WriteLine("B - China");
                    Console.WriteLine("C - He has always been red");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 16:
                    Console.WriteLine("What has Abraham Lincoln never done in any photographs?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Smile");
                    Console.WriteLine("B - Sneeze");
                    Console.WriteLine("C - Shown his hands");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 17:
                    Console.WriteLine("What have 26% of McDonald's Ontario admitted doing?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Undercooked the food");
                    Console.WriteLine("B - Dipping fingers in the soft drinks and ice cream");
                    Console.WriteLine("C - Putting bodily fluids in the food");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 18:
                    Console.WriteLine("Where would you find the Sea of Tranquility?");
                    Console.WriteLine("");
                    Console.WriteLine("A - On the Moon");
                    Console.WriteLine("B - On the Sun");
                    Console.WriteLine("C - On the Earth");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 19:
                    Console.WriteLine("What is the tallest building in the world?");
                    Console.WriteLine("");
                    Console.WriteLine("A - One World Trade Center");
                    Console.WriteLine("B - Shanghai Tower");
                    Console.WriteLine("C - Burj Khalifa");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
            }
            return answer;
        }

    }
}
