﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Easy
    {
        //Question Section:

        public bool Questionseasy(int a)
        {
            bool answer = false;
            string input = "";

            switch (a)
            {
                case 0:
                    Console.WriteLine("Which movie isn't a Disney movie?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Pochahontas");
                    Console.WriteLine("B - Stuart Little");
                    Console.WriteLine("C - Atlantis");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 1:
                    Console.WriteLine("What colour is the Coca Cola brand?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Black");
                    Console.WriteLine("B - Red");
                    Console.WriteLine("C - Pink");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 2:
                    Console.WriteLine("Who is the president of the United States?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Donald Trump");
                    Console.WriteLine("B - Barack Obama");
                    Console.WriteLine("C - Hillary Clinton");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 3:
                    Console.WriteLine("What does USA stand for?");
                    Console.WriteLine("");
                    Console.WriteLine("A - United States of America");
                    Console.WriteLine("B - It doesn't stand for anything");
                    Console.WriteLine("C - Under Serious Accusation");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 4:
                    Console.WriteLine("Who is the wizard there are 7 books and 8 movies about?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Newt Scamander");
                    Console.WriteLine("B - Merlin");
                    Console.WriteLine("C - Harry Potter");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 5:
                    Console.WriteLine("Who is Jesus?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Son of God");
                    Console.WriteLine("B - A student in the school, right?");
                    Console.WriteLine("C - Me of course");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 6:
                    Console.WriteLine("What is red");
                    Console.WriteLine("");
                    Console.WriteLine("A - Coca Cola");
                    Console.WriteLine("B - Blood");
                    Console.WriteLine("C - Water");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 7:
                    Console.WriteLine("What language does we code in?");
                    Console.WriteLine("");
                    Console.WriteLine("A - HTML");
                    Console.WriteLine("B - PythonScript");
                    Console.WriteLine("C - C#");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 8:
                    Console.WriteLine("What is Mario's buddy from the Super Mario games name?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Mario Jr.");
                    Console.WriteLine("B - Luigi");
                    Console.WriteLine("C - Sonic");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 9:
                    Console.WriteLine("Who is Pewdiepie?");
                    Console.WriteLine("");
                    Console.WriteLine("A - A antisocial psychopath in jail");
                    Console.WriteLine("B - A german youtuber");
                    Console.WriteLine("C - A swedish original content creator ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 10:
                    Console.WriteLine("What is AC/DC?");
                    Console.WriteLine("");
                    Console.WriteLine("A - An icecream sandwich");
                    Console.WriteLine("B - A country");
                    Console.WriteLine("C - A rock band");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }                    
                    break;
                case 11:
                    Console.WriteLine("What is GIT?");
                    Console.WriteLine("");
                    Console.WriteLine("A - A program");
                    Console.WriteLine("B - A sweet website");
                    Console.WriteLine("C - The new youtube");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 12:
                    Console.WriteLine("What is the operationsystem of most computers?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Mac OS");
                    Console.WriteLine("B - Linux");
                    Console.WriteLine("C - Windows");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 13:
                    Console.WriteLine("Which movie is Wolverine from?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Avengers");
                    Console.WriteLine("B - Justice League");
                    Console.WriteLine("C - X-men");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 14:
                    Console.WriteLine("What is a Golden Retriever?");
                    Console.WriteLine("");
                    Console.WriteLine("A - An award");
                    Console.WriteLine("B - A dog race");
                    Console.WriteLine("C - A computer model");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 15:
                    Console.WriteLine("In Dumbo, what type are the little animal?");
                    Console.WriteLine("");
                    Console.WriteLine("A - A mouse");
                    Console.WriteLine("B - A cat");
                    Console.WriteLine("C - There is no little animal");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 16:
                    Console.WriteLine("In what film trilogy did they use to destroy a ring?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Harry Potter");
                    Console.WriteLine("B - Lord of the Rings");
                    Console.WriteLine("C - The Hobbit");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 17:
                    Console.WriteLine("Who was the first man to walk the moon?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Kevin Magnussen");
                    Console.WriteLine("B - Neil Armstrong");
                    Console.WriteLine("C - Lance Legstrong");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 18:
                    Console.WriteLine("What is paper made of?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Trees");
                    Console.WriteLine("B - Grass");
                    Console.WriteLine("C - Plants");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 19:
                    Console.WriteLine("What killed the Dinosaurs?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Humans");
                    Console.WriteLine("B - Aliens");
                    Console.WriteLine("C - A huge asteroid");
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
