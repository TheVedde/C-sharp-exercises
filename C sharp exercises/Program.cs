using System;
using System.Collections.Generic;

namespace C_sharp_exercises
{
    public class Program : BaseClass
    {
        int a;
        int b;
        int c;
        int d;
        int x;
        int y;
        int z;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        public void start()
        {
            //program 1
            showProgramNumb();
            Console.WriteLine("Hello: " + "Vedran Zelen");
            //program 2
            showProgramNumb();
            Console.WriteLine(2 + 3);
            //program 3
            showProgramNumb();
            Console.WriteLine(3 / 3);
            //program 4
            showProgramNumb();
            programFour();
            //program 5
            showProgramNumb();
            programFive();
            //program 6
            showProgramNumb();
            programSix();
            //program 7
            showProgramNumb();
            programSeven();
            //program 8
            showProgramNumb();
            programEight();
            //program 9
            showProgramNumb();
            programNine();
            showProgramNumb();
            programTen();
            showProgramNumb();
            programEleven();
            showProgramNumb();
            programTwelve();
        }
        void programSixteen()
        {
            switchChar("Jackson");
            switchChar("Jeff");
        }

        void programFifteen()
        {
            Console.WriteLine(removeChar("Dancer", 2));
            Console.WriteLine(removeChar("Dancer", 1));
            Console.WriteLine(removeChar("Dancer", 6));
        }

        

        void programFourteen()
        {
            a = getNumber("Enter an amount of celsius: ");
            Console.WriteLine("in Celcius: " + a);
            Console.WriteLine("in Fahrenheit: " + (a / 5)* 9 + 32);
            Console.WriteLine("in Kelvin: " + (a + 273.15));
        }
        void programThirdteen()
        {
            a = getNumber("Enter a digit: ");
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(a + "" + a + "" + a);
                Console.WriteLine(a + " " + a);
                Console.WriteLine(a + " " + a);
                Console.WriteLine(a + " " + a);
                Console.WriteLine(a + " " + a);
                Console.WriteLine(a + "" + a + "" + a);
            }
        }

        void programTwelve()
        {
            a = getNumber("Enter a digit: ");
            Console.WriteLine();
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(a + " " + a + " " + a + " " + a);
                Console.WriteLine(a + "" + a + "" + a + ""+ a);
            }
        }

        void programEleven()
        {
            a = getNumber("Enter your age: ");
            Console.WriteLine("you dont look a day over " + a);
        }

        void programTen()
        {
            x = getNumber("Insert first number: ");
            y = getNumber("Insert second number: ");
            z = getNumber("Insert third number: ");
            Console.WriteLine((x + y)*z);
            Console.WriteLine(x*y + y*z);
        }
        void programNine()
        {
            a = getNumber("Insert first number: ");
            b = getNumber("Insert second number: ");
            c = getNumber("Insert third number: ");
            d = getNumber("Insert fourth number: ");

            List<int> list = new List<int>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            int result = a + b + c + d;
            int count = list.Count;
            int sum = result / count;
            Console.WriteLine("Average is: " + sum);
        }

        void programEight()
        {
            int a8th = getNumber("Insert first number: ");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(a8th + "*" + i + "=" + a8th * i);
            }
        }

        void programSeven()
        {
            int a = getNumber("Insert first number: ");
            int b = getNumber("Insert second number: ");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }


        void programSix()
        {
             a = getNumber("Insert first number: ");
             b = getNumber("Insert second number: ");
             c = getNumber("Insert third number: ");

            Console.WriteLine(a * b * c);
        }

        void programFive()
        {
         
             a = getNumber("Insert first number: ");
             b = getNumber("Insert second number: ");
          
            Console.WriteLine("First number: " + b);
            Console.WriteLine("Second number: " + a);
        }
        void programFour()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }



    }
}
