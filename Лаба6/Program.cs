using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Лаба6;
using System.IO;

namespace Variant16
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customers = new
            {
            FileStream lis = File.OpenRead(@"C:\Users\alexo\OneDrive\Рабочий стол\Laba6\lis.txt"),
            FileStream den = File.OpenRead(@"C:\Users\alexo\OneDrive\Рабочий стол\Laba6\den.txt"),
            FileStream pan = File.OpenRead(@"C:\Users\alexo\OneDrive\Рабочий стол\Laba6\pan.txt"),
            FileStream ilya = File.OpenRead(@"C:\Users\alexo\OneDrive\Рабочий стол\Laba6\ilya.txt")
            };



            var sorted = customers.OrderBy(ob => ob.familyname).ToArray();
            Console.WriteLine("Привет дружище, вот тебе список покупателей в алфавитном порядке: ");
            Console.WriteLine("------------------------------------------------");
            Array.ForEach(sorted, Console.WriteLine);
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine(" ");

            Console.WriteLine("А вот тебе список покупателей, номер кредитной карточки которых находится в заданном интервале: ");
            Console.WriteLine("------------------------------------------------");
            bool ex = false;
            foreach (Customer c in customers)
                if (c.cardnumber > 0098003456001200 && c.cardnumber < 8890440022004400)
                {
                    Console.WriteLine(c.ToString());
                    ex = true;
                }
            Console.WriteLine("------------------------------------------------");


            Customer obj = new Customer(0);
            int i = 1;
            for (; i < 120000; i++)
            {
                obj.objectGenerator(i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nКонец");


        }
    }
}