//Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok
//przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100 (za wyjątkiem lat podzielnych
//przez 400).
using System;

namespace RokPrzestepny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok: ");
            int year = int.Parse(Console.ReadLine());
            Rok();
            

        }
        static bool Check(int year)
        {
            if (year % 4 == 0 && year % 100 != 0) return true;
            else if (year%400==0) return true;
            else return false;
        }
        static void Rok()
        {
            for (int i = 0; i <= 2022; i++)
            {
                if (Check(i) == true)
                    Console.WriteLine(i+" Jest Przestępny");
                else Console.WriteLine(i+ "Nie jest");
            }
        }
    }
}
