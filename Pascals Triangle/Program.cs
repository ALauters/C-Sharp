using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int height = 0;

                Console.WriteLine("Enter the height of your triangle as an integer (max height = 50)");
                height = int.Parse(Console.ReadLine());

                bool height_bool = false;
                while (!height_bool)
                {
                    if (height > 50 || height < 0)
                    {
                        Console.WriteLine("Please Enter a number greater than 0 and less than 50");
                        height = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        height_bool = true;
                    }
                }
                
                // creation of arrays
                int[][] triangleArrays = new int[height + 1][];
                for(int row = 0; row < height; row++)
                {
                    triangleArrays[row] = new int[row+1];
                }

                // initial assignment
                triangleArrays[0][0] = 1;

                // auto filling of rows based on height
                for(int row = 0; row < height-1; row++)
                {
                    for(int col = 0; col < triangleArrays[row].Length; col++)
                    {                        
                        triangleArrays[row+1][col] = triangleArrays[row+1][col] + triangleArrays[row][col];

                        triangleArrays[row+1][col+1] = triangleArrays[row+1][col+1] + triangleArrays[row][col];
                    }
                }

                for(int row = 0; row < height; row++)
                {
                    Console.Write(new String(' ', (height - row) * 2));
                    for( int col = 0; col < row+1; col++)
                    {
                        Console.Write("{0,4}", triangleArrays[row][col]);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}