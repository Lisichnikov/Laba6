using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба6
{
    public class Customer
    {
        public string familyname;
        public string name;
        public string surname;
        public string address;
        public long phonenumber;
        public long cardnumber;
        public int bankaccountnumber;
        public int k;

        // конструктор по умолчанию 
        public Customer(int i)
        {
            familyname = "unknown";
            name = "unknown";
            surname = "unknown";
            address = "unknown";
            phonenumber = 0;
            cardnumber = 0;
            bankaccountnumber = 0;
            k = i;
        }
        // конструктор с параметрами
        public Customer(string familyname, string name, string surname, string address, long phonenumber, long cardnumber, int bankaccountnumber)
        {
            this.familyname = familyname;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phonenumber = phonenumber;
            this.cardnumber = cardnumber;
            this.bankaccountnumber = bankaccountnumber;
        }

        // деструктор
        ~Customer()
        {
            Console.WriteLine("Объект {0} уничтожен", k);
        }

        // метод создающий и тут же уничтожающий объект
        public void objectGenerator(int i)
        {
            Customer customers = new Customer(i);
        }
        
        public override string ToString()
        {
            return familyname + ", " + name + ", " + surname + ", " + address + ", " + phonenumber + ", " + cardnumber + ", " + bankaccountnumber + ", " + k;
        }
    }
}