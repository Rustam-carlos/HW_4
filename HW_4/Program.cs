using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cars[] cars = new Cars [5];

            cars[0] = new Cars("sport car", "BMW", 350, 2500, 4, 70);
            cars[1] = new Cars("truk", "Mersedes", 180, 5500, 2, 350);
            cars[2] = new Cars("passenger car", "Audi", 200, 2000, 4, 50);
            cars[3] = new Cars("sport car", "Porshe", 380, 1900, 2, 70);
            cars[4] = new Cars("passenger car", "WolksVagen", 200, 2500, 4, 70);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("-----------------------------------------");
                cars[i].Show();
                Console.WriteLine("-----------------------------------------");
            }

            Cars.DisplayCounter();

            Console.ReadLine();

        }
    }
}
