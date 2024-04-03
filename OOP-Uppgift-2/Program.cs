using OOP_Uppgift_2;
using System;

namespace Uppgift2
{
    class Program
    {
        static void Main()
        {
            Namn namn = new();

            namn.SetNamn = "Zacharias Bergenholtz";
            Console.WriteLine(namn.SetNamn);
        }
    }
}