using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Easy
    {
        //Question Section:

        public bool Question1()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Which movie isn't a Disney movie?");
            Console.WriteLine("");
            Console.WriteLine("A - Pochahontas");
            Console.WriteLine("B - Stuart Little");
            Console.WriteLine("C - Atlantis");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "b")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question2()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What colour is the Coca Cola brand?");
            Console.WriteLine("");
            Console.WriteLine("A - Black");
            Console.WriteLine("B - Red");
            Console.WriteLine("C - Pink");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "b")
            {
                answer = true;
            }
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question4()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What does USA stand for?");
            Console.WriteLine("");
            Console.WriteLine("A - United States of America");
            Console.WriteLine("B - It doesn't stand for anything");
            Console.WriteLine("C - Under Serious Accusation");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question5()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Who is the wizard there are 7 books and 8 movies about?");
            Console.WriteLine("");
            Console.WriteLine("A - Newt Scamander");
            Console.WriteLine("B - Rubeus Hagrid");
            Console.WriteLine("C - Harry Potter");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }


        public bool Question6()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Who is Jesus?");
            Console.WriteLine("");
            Console.WriteLine("A - Son of God");
            Console.WriteLine("B - A student in the school, right?");
            Console.WriteLine("C - Me of course");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "b")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question8()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What language does we code in?");
            Console.WriteLine("");
            Console.WriteLine("A - HTML");
            Console.WriteLine("B - PythonScript");
            Console.WriteLine("C - C#");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question9()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What is Mario's buddy from the Super Mario games name?");
            Console.WriteLine("");
            Console.WriteLine("A - Mario Jr.");
            Console.WriteLine("B - Luigi");
            Console.WriteLine("C - Sonic");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;

        }

        public bool Question10()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Who is Pewdiepie?");
            Console.WriteLine("");
            Console.WriteLine("A - An antisocial psychopath in jail");
            Console.WriteLine("B - A youtuber");
            Console.WriteLine("C - An actor");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "b")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question11()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What is AC/DC?");
            Console.WriteLine("");
            Console.WriteLine("A - An icecream sandwich");
            Console.WriteLine("B - A country");
            Console.WriteLine("C - A rock band");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question13()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What is the operationsystem of this computer?");
            Console.WriteLine("");
            Console.WriteLine("A - Mac OS");
            Console.WriteLine("B - Linux");
            Console.WriteLine("C - Windows");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question14()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Which movie is Wolverine from?");
            Console.WriteLine("");
            Console.WriteLine("A - Avengers");
            Console.WriteLine("B - Justice League");
            Console.WriteLine("C - X-men");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question15()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What is a Golden Retriever?");
            Console.WriteLine("");
            Console.WriteLine("A - An award");
            Console.WriteLine("B - A dog race");
            Console.WriteLine("C - A computer model");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "b")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question16()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("In Dumbo, what type are the little animal?");
            Console.WriteLine("");
            Console.WriteLine("A - A mouse");
            Console.WriteLine("B - A cat");
            Console.WriteLine("C - There is no little animal");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question17()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("In what film trilogy did they use to destroy a ring?");
            Console.WriteLine("");
            Console.WriteLine("A - Harry Potter");
            Console.WriteLine("B - Lord of the Rings");
            Console.WriteLine("C - The Hobbit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "b")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question18()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("Who was the first man to walk the moon?");
            Console.WriteLine("");
            Console.WriteLine("A - Kevin Magnussen");
            Console.WriteLine("B - Neil Armstrong");
            Console.WriteLine("C - Lance Legstrong");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "b")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

        public bool Question19()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("What is paper made of?");
            Console.WriteLine("");
            Console.WriteLine("A - Trees");
            Console.WriteLine("B - Grass");
            Console.WriteLine("C - Plants");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                answer = true;
            }
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            if (input.ToLower() == "c")
            {
                answer = true;
            }
            Console.ResetColor();
            return answer;
        }

    }
}
