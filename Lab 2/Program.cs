using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            {

                Console.WriteLine("Кольори?");
                switch (Console.ReadLine())
                {
                    case "1": Console.WriteLine("червоний"); break;
                    case "2": Console.WriteLine("синій"); break;
                    case "3": Console.WriteLine("зелений"); break;
                    case "4": Console.WriteLine("помаранчевий"); break;
                    case "5": Console.WriteLine("голубий"); break;
                    case "6": Console.WriteLine("жовтий"); break;
                    case "7": Console.WriteLine("фіолетовий"); break;



                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }  
     
  }