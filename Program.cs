using System;
using System.Collections.Generic;
using System.Text;

namespace ChangingTheWorld
{
    class Program
    {
        
        public static void runner1()
        {
            int maxWord = 40;
            String post = "This is the longes string in the universe and i want us to please summarize it into something smaller";
            Console.WriteLine(Summarizer.summerizer(maxWord, post));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Changing the World!");

            checked
            {
                //  byte overflow = 255;
                // overflow++;
                // Console.WriteLine(overflow);
            }
            bool isDead = false;
            Console.WriteLine(isDead);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            int yellow = 10;
            byte blue = (byte)yellow;
            string isTrue = "true";
            bool convert = Convert.ToBoolean(isTrue);

            string[] names = new string[2] { "home", "emmanuel" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            string iterable = "Oriola Emmanuel";
            foreach (var name in iterable )
            {
                Console.WriteLine("in list " + name);
            }foreach (var name in names )
            {
                Console.WriteLine("in list " + name);
            }

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            List<int> list = new List<int>();
            list.Add(blue);

            Array.Clear(numbers, 0, 3);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now);
            Console.WriteLine(today);
            String trim = " Oriola Emmanuel ";
            Console.WriteLine(trim.Trim());
            String[] split = trim.Split(" ");
            Console.WriteLine(split[0],split[1]);
            Console.WriteLine("Replaced : " + trim.Replace("Emmanuel", "Emmaccen"));
            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid String supplied");

            String age = "25";
            int converted = Convert.ToByte(age);
            Program.runner1();
        }
    } 
}
 