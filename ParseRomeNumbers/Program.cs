using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanAndArabicNumericals
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
       
            bool isRunning = true;
            Roman roman = new Roman();
            Arabic arabic = new Arabic();
          while (isRunning)
            { 
            Console.Write("Введите арабское число: ");
            string input = Console.ReadLine();
                if (input != "Exit")
                {

                    string romanNumericals =roman.ConvertToRomanNumericals(input);
                    Console.WriteLine($"Конвертим в римские цифры...Done! {romanNumericals}");
                    string arabicNumericals = arabic.ConvertToArabicNumericals(romanNumericals);
                    Console.WriteLine($"Конвертим в арабские цифры...Done! {arabicNumericals}");


                }
                else isRunning = false;
        }

            Console.ReadKey();

        }
    }
}
