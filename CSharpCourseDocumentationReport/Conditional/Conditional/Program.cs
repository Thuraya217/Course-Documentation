﻿namespace Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Data Type:");  // Data Types
            //int number1;
            //int number2;

            //Console.WriteLine("Enter the first Number");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Second Number");
            //number2 = int.Parse(Console.ReadLine());

            //int result = number1 - number2;
            //Console.WriteLine(result);

            //----------------------------------------------------------

            //Console.WriteLine("Variables:");  //  Constants Variables
            //double PI = 3.14;
            //Console.WriteLine("PI is equal=" + PI);


            //Console.WriteLine("Variables:");  // Read-Only Variables
            //int Age;
            //string name;
            //Console.WriteLine("Enter your name and your age:");
            //Age = int.Parse(Console.ReadLine());
            //name = Console.ReadLine();
            //Console.WriteLine("Your name and age is:" + name + Age);

            //-----------------------------------------------------------

            Console.WriteLine("input/ output statements:");  // input/ output statements

            int Age;
            string name;
            int Mark;
            
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your mark:");
            Mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Student inforamtion:" + name + Age + Mark);
            Console.WriteLine(Age );
            Console.WriteLine(Mark);
        }
    }
}
