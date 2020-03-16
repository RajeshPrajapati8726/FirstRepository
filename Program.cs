using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
   public class Program
    {
        public delegate void displayDelegate(string msg);
        
        static void Main(string[] args)
        {
            int c = 10;

            c <<= 4;

            Console.WriteLine("Hello World!"+c);

            Dictionary<int,string> obj = new Dictionary<int, string>();

            obj.Add(1,"Rajesh");

            obj.Add(2,"Gopal"); obj.Add(3,"Mahi"); obj.Add(4,"Akash");

            Console.WriteLine("Hello World!" + obj[3]);

            displayDelegate displaydelegate;

            displaydelegate = display;         

            displaydelegate += display2;

            //displaydelegate += display3;


            // displaydelegate("Hello Rajesh");
            Class1 t = new Class1();

            t.PassingDelegateAsAArgs(displaydelegate);



        }

        public static void display(string msg)
        {
            Console.WriteLine(msg+"dfsghfd");
            Console.ReadLine();
        }


        public static void display2(string msg)
        {
            Console.WriteLine(msg+"g");
            Console.ReadLine();
        }

        //public static void display3(string msg)
        //{
        //    Console.WriteLine(msg);
        //}
    }
}
