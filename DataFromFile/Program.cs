using System;
using System.IO;
namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wagwan, mis su lemmik värv on, blood?");
            string FavColour = Console.ReadLine();

            string directorypath = @"C:\Users\opilane\samples";
            string FileName = "personality.txt";
            string FullPath = $@"{directorypath}\{FileName}";
            string[] dataFromFile = File.ReadAllLines(FullPath);


            private static string GetLineFromFileData(string userImput)
            {
                string[] dataFromFile = ReadDataFromFile();
                string result = "";
                foreach (string line in dataFromFile) ;
            }

            string[] dataFromfile = File.ReadAllLines(FullPath);

           
            
            
            foreach (string line in dataFromfile) 
            {
                if (line.Contains(FavColour))
                {
                    Console.WriteLine(line) ;
                    break;                
                }
            }

        }
    }  
}
