using System;

namespace Deliverable2
{
    class Program
    {

        public static void Main(string[] args)
        {

            string lastinput = null;

            while (lastinput != "bye")
            // Continue asking until a correct answer is given.
            {
                Console.WriteLine("Chat with Bot");
                string answer = Console.ReadLine().ToLower();

                if (lastinput == answer)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else
                if (answer == "hello")
                { 
                    Console.WriteLine("Hi good to see you"); 
                }
                else
                if (answer == "sup") 
                { 
                    Console.WriteLine("I'm good"); 
                }
                else
                if (answer == "hello there")
                { 
                    Console.WriteLine("General Kenobi");
                }
                else
                if (answer == "bye") 
                { 
                    Console.WriteLine("Goodbye"); 
                }

                lastinput = answer;

            }

        }
    }
}