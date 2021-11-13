using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Введите строку:\t");
            string input = Console.ReadLine();
            string input1 = input.Replace(" ", "");
            char[] obrinput = input1.ToCharArray();
            Array.Reverse(obrinput);
            string finaltext = new string(obrinput);
            if (input1 == finaltext)
            {
                Console.Write("Введенная фраза палиндром");
            }
            else
                Console.Write("Введенная фраза не палиндром");
                Console.ReadKey(); 
            }
                }
}
