namespace JAProject
{
    internal class Program
    {

        static void RandomPopulate(int[][] ja)
        {
            Random r = new Random();
            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].Length; j++)
                {
                    ja[i][j] = r.Next(100); //0..99
                }
            }
        }

        static void DisplayJALA(int[][] ja)
        {
            Console.WriteLine("Elements of the Jugged Array: ");
            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].Length; j++)
                {
                    Console.Write($"{ja[i][j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void DisplayJA2D(int[][,] ja)
        {
            Console.WriteLine("Elements of the Jugged Array: ");
            for (int i = 0; i < ja.Length; i++)
            {
                Console.WriteLine($"Cell {i}: ");
                for (int j = 0; j < ja[i].GetLength(0); j++)
                {
                    for (int k = 0; k < ja[i].GetLength(1); k++)
                    {
                        Console.Write($"{ja[i][j, k],3}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {

            Console.WriteLine("How many rows?");
            int row = int.Parse(Console.ReadLine());


            int[][] ja = new int[row][];
            int col;

            for (int i = 0; i < ja.Length; i++)
            {
                Console.WriteLine($"Enter total columns for row {i + 1}: ");
                col = int.Parse(Console.ReadLine());
                ja[i] = new int[col];
            }


            RandomPopulate(ja);
            DisplayJALA(ja);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Accessing elements from a Jugged array of a 2D-Array: ");

            int[][,] ja2D = new int[3][,]
                {
                    new int[,] { {1,2} },
                    new int[,] { {1,4}, {4,8}, {7,12} },
                    new int[,] { {3,2,1,0}, {5,5,4,3}}
                };

            DisplayJA2D(ja2D);

            //Console.WriteLine(ja3D[1][1,1]);  //prints 8
            //Console.WriteLine(ja3D[2][1,3]);  //prints 3

            Console.WriteLine("Length: " + ja2D.Length);  //prints 3
            Console.WriteLine("Rank: " + ja2D.Rank);  //prints 1

            Console.WriteLine("Size of the first dimension: " + ja2D.GetLength(0));  //prints 3

            Console.WriteLine("Column size of the third cell (cell 2) of Jugged Array: " + ja2D[2].GetLength(1)); //prints 4


        }
    }
}
