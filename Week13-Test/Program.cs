using System;
using System.IO;

namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\opilane\samples";

            Console.WriteLine("Siseta kausta nimi:");
            string KasutajaKaust = Console.ReadLine();

            string newDirectory = @$"{newPath}\{KasutajaKaust}";
            bool DirectoryExists = Directory.Exists(newDirectory);

            if (DirectoryExists)
            {
                Console.WriteLine($"{KasutajaKaust} already exists in Samples.");
            }
            else
            {
                Directory.CreateDirectory(newDirectory);
                Console.WriteLine($"Directory {KasutajaKaust} has been created.");
            }
            Console.ReadLine();
        }
    }
}
