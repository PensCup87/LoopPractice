using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////initializes 
            //int total = 0;
            //int[] numbers = { 2, 9, 19, 87, 71, 99 };

            ////For Loop Time            
            //    for(int i = 0; i < numbers.Length; i++)
            //    {
            //        if(total > 16)
            //        {
            //            for(int j = 0; j < numbers.Length; j++)
            //            {
            //                Console.WriteLine("Go Irish");
            //            }

            //        }
            //        total = total + numbers[i];
            //        Console.WriteLine(total);
            //    }          

            ////Hello Loop!
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("hello");
            //}

            ////Hello Goodbye loop
            //for(int i = 0; i < 8; i++)
            //{
            //    if (i != 3 && i != 7)
            //    {
            //        Console.WriteLine("Hello");
            //    }
            //    else if (i == 3)
            //    {
            //        Console.WriteLine("Bonjour");
            //    }
            //    else if (i == 7)
            //    {
            //        Console.WriteLine("Good bye");
            //    }
            //}

            ////Fizz Buzz
            //for(int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if(i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int[] engineSize = new int[5];
            for(int i = 0; i < engineSize.Length; i++)
            {
                Console.WriteLine("List some engine sizes in CCs");
                int engine = int.Parse(Console.ReadLine());
                
                //this puts each value into an index
                engineSize[i] = engine;
                //Console.WriteLine(engineSize[i]);
            }
            foreach(int engine in engineSize)
            {
                Console.WriteLine(engine);
            }


        }
    }
}
