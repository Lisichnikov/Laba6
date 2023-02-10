using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Лаба6;

namespace Variant16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
{
new Customer ("Лисичников", "Алексей", "Алексеевич", "Шуист", 89876543211, 7876542300008756, 0001),
new Customer ("Антипкин", "Денис", "Павлович", "Телегино", 89875102996, 0040320878560000, 0002),
new Customer ("Тупицин", "Илья", "Алексеевич", "Кургановка", 89560234501, 6700880823043498, 0003),
new Customer ("Панькин", "Данила", "Сергеевич", "Kamenka", 89876590123, 4500300020207856, 0004)
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