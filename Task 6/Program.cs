using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        { int mlength = 0;
            int identif = 0;
            int i;

            Console.Write("Введите строку:\t");
            string input = Console.ReadLine();
            string[] array = input.Split(new Char[] { ' ' });
            for (i = 0; i< array.Length; i++)
            { if (array[i].Length > mlength)
                {
                    mlength = array[i].Length;
                    identif = i;
                } 
            }
            Console.Write("Самое длинное слово в вашей фразе:\t {0}", array[identif]);
            Console.ReadKey();
        }
    }
}
