using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_exercises
{
    public abstract class BaseClass
    {
        int val = 1;
        int a;
        int b;
        public static void handleUserInput()
        {

            Console.WriteLine("Please insert two numbers");
            int a = getNumber("Insert first number: ");
            int b = getNumber("Insert second number: ");
        }
        
        public string switchChar(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(str.Length - 2) + str.Substring(0, 1) : str;

        }

        public string removeChar(string str, int pos)
        {
            return str.Remove(pos, 1);
        }

        public static int getNumber(string message)
        {
            int number;
            do
            {
                Console.Write(message);
                bool parser = Int32.TryParse(Console.ReadLine(), out number);

                if (!parser)
                {
                    Console.WriteLine("None valid number");
                    continue;
                }
                break;
            } while (true);

            return number;
        }

        public void showProgramNumb()
        {
            Console.WriteLine(val + "# program");
            val++;
        }

        /*    static void Main(string[] args)
            {
                Console.WriteLine("Welcome");
                handleUserInput();
            }
            */
    }
}
