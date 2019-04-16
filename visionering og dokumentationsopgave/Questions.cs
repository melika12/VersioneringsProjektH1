using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Questions
    {
        //Question Section:

        public bool Question1()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question2()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }


        public bool Question3()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question4()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Do Multiverses exist?");
            Console.WriteLine("");
            Console.WriteLine("A - Maybe");
            Console.WriteLine("B - Yes");
            Console.WriteLine("C - Only in fiction");
            input = Console.ReadLine();
            answer = true;
            return answer;
        }

        public bool Question5()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Which Traditional beloved Disney movie?");
            Console.WriteLine("");
            Console.WriteLine("A - The Jungle Book");
            Console.WriteLine("B - Beauty and the Beast");
            Console.WriteLine("C - The Lion King");
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            return answer;
        }


        public bool Question6()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question7()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question8()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question9()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What does 'Bing' stand for?");
            Console.WriteLine("");
            Console.WriteLine("A - Because it's not Google");
            Console.WriteLine("B - It doesn't stand for anything");
            Console.WriteLine("C - Being intelligent never grants");
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            return answer;
            
        }

        public bool Question10()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question11()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What is acdc?");
            Console.WriteLine("");
            Console.WriteLine("A - An icecream sandwich");
            Console.WriteLine("B - A country");
            Console.WriteLine("C - A rock band");
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            return answer;
        }

        public bool Question12()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question13()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question14()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Who are the real Logan");
            Console.WriteLine("");
            Console.WriteLine("A - He's in our class");
            Console.WriteLine("B - Dead");
            Console.WriteLine("C - pfff: Wolverrine!");
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            return answer;
        }

        public bool Question15()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question16()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("In Dumbo, what type are the little animal?");
            Console.WriteLine("");
            Console.WriteLine("A - A mouse");
            Console.WriteLine("B - A rat");
            Console.WriteLine("C - There is no little animal");
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            return answer;
        }

        public bool Question17()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What is the best Cola?");
            Console.WriteLine("");
            Console.WriteLine("A - Mauntain DEW!!!");
            Console.WriteLine("B - Pepsi");
            Console.WriteLine("C - Coca Cola");
            input = Console.ReadLine();
            if (input.ToLower() == "a" || input.ToLower() == "c")
            {
                answer = true;
            }
            return answer;
        }

        public bool Question18()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question19()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

        public bool Question20()
        {
            bool answer = false;
            string input = "";
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
            return answer;
        }

    }
}
