using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("witaj");
            Console.WriteLine("Podaj imie:");
            string imie;
            imie = Console.ReadLine();

            Console.WriteLine("podaj nazwisko");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko);

            Console.WriteLine("Podaj wiek");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if (wiek < 67)
            {
                Console.WriteLine("Do emerytury zostalo ci {0} lat", 67 - wiek);
            }
            else
            {
                Console.WriteLine("Jestes na emeryturze");
            }





            Console.ReadKey();
        }
    }
}
