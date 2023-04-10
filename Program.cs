using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IClone
{
    class Tank : ICloneable
    {

        public Tank(int mass,int engine,int max_speed,int power_reserve,int fuel_t,int armor,int consumption) {
            this.mass = mass;
            this.engine = engine;
            this.max_speed = max_speed;
            this.power_reserve = power_reserve;
            this.fuel_t = fuel_t;
            this.armor = armor;
            this.consumption = consumption; 
        }

        public void print()
        {
            Console.WriteLine($"Mass - {mass} kg");
            Console.WriteLine($"Engine - {engine} hp");
            Console.WriteLine($"Max speed - {max_speed} km");
            Console.WriteLine($"Power reserve - {power_reserve} km");
            Console.WriteLine($"Fuel in tank - {fuel_t} L");
            Console.WriteLine($"Armor - {armor} mm");
            Console.WriteLine($"Consumption - {consumption} L/100km");
            Console.WriteLine("--------------------------------------");
        }

        public object Clone()
        {

            return MemberwiseClone();
        }

        public int mass, engine, max_speed, power_reserve, fuel_t,armor,consumption;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tank -> ");
            Tank T34 = new Tank(1200,700,60,500,1200,300,250);
            T34.print();

            Console.WriteLine("Clone -> ");
            Tank T34_2 = (Tank)T34.Clone();
            T34_2.print();

            T34.fuel_t = 1700;
            T34_2.max_speed = 70;

            Console.WriteLine("Tank after change -> ");
            T34.print();

            Console.WriteLine("Clone after change -> ");
            T34_2.print();

            Console.ReadKey();
        }
    }
}
