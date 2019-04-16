using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Medium
    {
        //Question Section:

        public bool Questionsmedium(int a)
        {
            bool answer = false;
            string input = "";

            switch (a)
            {
                case 0:
                    Console.WriteLine("What got the largest gravitational pull?");
                    Console.WriteLine("");
                    Console.WriteLine("A - The Sun");
                    Console.WriteLine("B - A black hole");
                    Console.WriteLine("C - Yo mama");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 1:
                    Console.WriteLine("Which year is it 2 years after, 4 years before?");
                    Console.WriteLine("");
                    Console.WriteLine("A - 2015");
                    Console.WriteLine("B - 2019");
                    Console.WriteLine("C - 2017");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 2:
                    Console.WriteLine("What is Tupperware?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Brand");
                    Console.WriteLine("B - Porcelain");
                    Console.WriteLine("C - Clothes");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 3:
                    Console.WriteLine("Do Multiverses exist?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Maybe");
                    Console.WriteLine("B - Yes");
                    Console.WriteLine("C - Only in fiction");
                    input = Console.ReadLine();
                    answer = true;
                    break;
                case 4:
                    Console.WriteLine("Which Traditional beloved Disney movie is reanimated and in theaters soon?");
                    Console.WriteLine("");
                    Console.WriteLine("A - The Jungle Book");
                    Console.WriteLine("B - Beauty and the Beast");
                    Console.WriteLine("C - The Lion King");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 5:
                    Console.WriteLine("Who ended world war 2");
                    Console.WriteLine("");
                    Console.WriteLine("A - The Chinese");
                    Console.WriteLine("B - Heil Hitler");
                    Console.WriteLine("C - Nuke them (USA)");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 6:
                    Console.WriteLine("What is black and gives a lot of energy");
                    Console.WriteLine("");
                    Console.WriteLine("A - Liquorise");
                    Console.WriteLine("B - Blood sausage");
                    Console.WriteLine("C - Coffee");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 7:
                    Console.WriteLine("3*3+3+3*3+3?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Math is stupid");
                    Console.WriteLine("B - 3*pi");
                    Console.WriteLine("C - 24");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c" || input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;
                case 8:
                    Console.WriteLine("What does 'Bing' stand for?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Because it's not Google");
                    Console.WriteLine("B - It doesn't stand for anything");
                    Console.WriteLine("C - Being intelligent never grants");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a" || input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 9:
                    Console.WriteLine("What movie series is Bellatrix Lestrange from?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Fantastic Beasts and where to find them");
                    Console.WriteLine("B - Lord of the Rings");
                    Console.WriteLine("C - Harry Potter");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 10:
                    Console.WriteLine("What kind of game is Counter Strike?");
                    Console.WriteLine("");
                    Console.WriteLine("A - A fighting video game");
                    Console.WriteLine("B - A shooting game");
                    Console.WriteLine("C - A racing game");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 11:
                    Console.WriteLine("Who is Leonardo Da Vinci?");
                    Console.WriteLine("");
                    Console.WriteLine("A - An actor");
                    Console.WriteLine("B - A popstar");
                    Console.WriteLine("C - A true genius");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 12:
                    Console.WriteLine("The Danish Queen's name is?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Elizabeth 2.");
                    Console.WriteLine("B - Margrethe 2.");
                    Console.WriteLine("C - Margrethe 1.");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 13:
                    Console.WriteLine("Who was Charles Darwin?");
                    Console.WriteLine("");
                    Console.WriteLine("A - A scientist");
                    Console.WriteLine("B - An author");
                    Console.WriteLine("C - A biologist among other things");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 14:
                    Console.WriteLine("What is Mars One?");
                    Console.WriteLine("");
                    Console.WriteLine("A - A project trying to settle on Mars");
                    Console.WriteLine("B - A new type of Cocio");
                    Console.WriteLine("C - A movie");
                    input = Console.ReadLine();
                    if (input.ToLower() == "c")
                    {
                        answer = true;
                    }
                    break;
                case 15:
                    Console.WriteLine("Who plays Genie in the new reanimated movie of 'Aladdin'?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Kevin Hart");
                    Console.WriteLine("B - Will Smith");
                    Console.WriteLine("C - Arnold Schwarznegger");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 16:
                    Console.WriteLine("What does WOW stand for?");
                    Console.WriteLine("");
                    Console.WriteLine("A - It doesn't stand for anything, it's an impression when you are surprised");
                    Console.WriteLine("B - World of Warcraft, it's a game");
                    Console.WriteLine("C - World of Web");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a" || input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 17:
                    Console.WriteLine("Which is the only American state to begin with the letter 'p'?");
                    Console.WriteLine("");
                    Console.WriteLine("A - Pentagon");
                    Console.WriteLine("B - Pennsylvania");
                    Console.WriteLine("C - Palm Springs");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 18:
                    Console.WriteLine("Where is Sunny Beach?");
                    Console.WriteLine("");
                    Console.WriteLine("A - On any beach in Bulgaria");
                    Console.WriteLine("B - On the black sea coast in Bulgaria");
                    Console.WriteLine("C - On the red sea coast in Bulgaria");
                    input = Console.ReadLine();
                    if (input.ToLower() == "b")
                    {
                        answer = true;
                    }
                    break;
                case 19:
                    Console.WriteLine("What is the purpose of GIT?");
                    Console.WriteLine("");
                    Console.WriteLine("A - To easier work together in teams as a programmer");
                    Console.WriteLine("B - To automate robots so programmers don't have huge amount of work");
                    Console.WriteLine("C - A drawing program like PhotoShop");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        answer = true;
                    }
                    break;

            }

            return answer;
        }

    }
}
