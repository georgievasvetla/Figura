using System;

namespace figura2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Vavedi stranite na figurata: ");
            Figura obj1 = new Pravoagalnik(int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()));
            double areaPravoagalnik =obj1.Area();
            double PPravagalnik = obj1.Perimetar();
            Console.WriteLine("S={0:f2}", areaPravoagalnik);
            Console.WriteLine("P={0:f2}", PPravagalnik);


        }
    }
}
