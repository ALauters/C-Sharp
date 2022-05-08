using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = Path.Combine("C:\\", "Users", "Austin", "Desktop", "git", "C-Sharp", "File_IO_Basics", "test.txt");

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();

            // Console.WriteLine(filepath);

            // Printing out all the lines from the file
            foreach(String line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Brian, Purple, 26");
            File.WriteAllLines(filepath, lines);

            

        }
    }
}