using AbstractClassHomework.Models;
using System;

namespace AbstractClassHomework
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What are you doing?");
            Console.WriteLine("1-Square area" +
                   " 2-Rectangular area " +
                   " 0- End");
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {               
                if (num == 1)
                {
                    float side = Convert.ToInt32(Console.ReadLine());
                    Square square = new Square(side);
                    Console.WriteLine(square.CalcArea());
                    break;
                }
                else if (num == 2)
                {      
                    float width = Convert.ToInt32(Console.ReadLine());
                    float length = Convert.ToInt32(Console.ReadLine());
                    Rectangular rectangular = new Rectangular(width, length);
                    Console.WriteLine(rectangular.CalcArea());
                }
                else
                {
                    do
                    {
                        Console.WriteLine("What are you doing?");
                        Console.WriteLine("1-Square area" +
                               " 2-Rectangular area " +
                               " 0- End");
                        num= Convert.ToInt32(Console.ReadLine());
                            if (num == 0)
                        {
                            Environment.Exit(0);
                        }
                    } while (num != 0 || num != 1 || num != 2);
                   
                }
                break;


            } while (num!=0 || num!=1 || num!=2);
          
          
        }
        
    }


}
