using System;

namespace File_IO_Basics 
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
            // foreach(String line in lines)
            // {
            //     Console.WriteLine(line);
            // }

            // lines.Add("Brian, Purple, 26");
            // File.WriteAllLines(filepath, lines);

            List <Person> people = new List<Person>();

            foreach(string line in lines)
            {
                string[] items = line.Split(',');
                Person p = new Person(items[0], items[1], items[2]);
                people.Add(p);
            }

            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }

        }
    }
}