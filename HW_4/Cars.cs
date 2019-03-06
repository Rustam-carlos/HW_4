using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    enum Models { BMW, Mersedes, Audi, Porshe, WolksVagen, Nissan, Toyota, handicraft }
    partial class Cars
    {
        private string _type { get; set; }        
        private string _mod { get; set; }
        private int _speed { get; set; }
        private double _weight { get; set; }
        private int _pass { get; set; }
        private static int _min_fuel { get; set; } = 5;
        private static int count = 0;
        
        static Cars()
        {    
            //count++;
        }
        public Cars(int speed, double weight, int pass)
        {            
            _speed = speed;
            _weight = weight;
            _pass = pass;
            count++;
        }
        public Cars(string type, string mod, int speed, double weight, int pass, int Fuel)
        {
            _type = type;
            _mod = mod;
            _speed = speed;
            _weight = weight;
            _pass = pass;
            _min_fuel = 5;
            count++;
        }
        partial void Pr();
        public void Show()
        {
            Pr();
        }

        public static void DisplayCounter()
        {
            Console.WriteLine($"Создано {count} объектов ");
        }
        
    }
}
