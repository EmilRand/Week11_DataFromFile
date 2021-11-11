using System;
using System.IO;
namespace Chuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorypath = @"C:\Users\opilane\samples";
            string FileName = "chuck.txt";
            string FullPath = $@"{directorypath}\{FileName}";
            
            string[] dataFromFile = File.ReadAllLines(FullPath);
            Random rnd = new Random();
            Console.WriteLine(dataFromFile[rnd.Next(dataFromFile.Length)]);

        }
    }
}
