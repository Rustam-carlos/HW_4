using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    partial class Cars
    {
        partial void Pr()
        {
            Console.WriteLine("Тип машины - \t\t\t" + _type);
            Console.WriteLine("Марка машины - \t\t\t" + _mod);
            Console.WriteLine("Макс. скорость машины - \t" + _speed);
            Console.WriteLine("Вес машины - \t\t\t" + _weight);
            Console.WriteLine("Колличество макс. пасажиров - \t" + _pass);
        }
    }
}
