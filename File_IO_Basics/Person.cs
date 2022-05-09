using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Basics
{
    class Person
    {
        public Person(string First_name, string Favorite_color, string Age)
        {
            this.First_name = First_name;
            this.Favorite_color = Favorite_color;
            this.Age = Age;
        }

        public string First_name { get; set; }

        public string Favorite_color { get; set; }

        public string Age { get; set; }

        public override string ToString()
        {
            return $"First Name: {First_name} Favorite Color: {Favorite_color} Age: {Age}";
        }

    }
}
