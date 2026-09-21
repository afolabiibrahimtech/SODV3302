namespace LinearArrayProject
{
    internal class Program
    {
        static void DisplayLinearArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }

        static void RandomPopulate(int[] x)
        {
            Random r = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(1, 100); //in range 1..99
            }
        }

        static int isFound(int[] x, int sVal)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == sVal)
                    return i; //in range 1..99
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] x;
            Console.WriteLine("Enter the array size: ");
            int sz = int.Parse(Console.ReadLine());
            x = new int[sz];
            RandomPopulate(x);
            DisplayLinearArray(x);

            Console.WriteLine("Enter a search value: ");
            int sVal = int.Parse(Console.ReadLine());

            int index = isFound(x, sVal);

            if (index >= 0)
            {
                Console.WriteLine($"The search value {sVal} is found at index: {index}");
            }
            else
            {
                Console.WriteLine("The search value is not found!");
            }

            Console.WriteLine($"Length of the array: {x.Length}");
            Console.WriteLine($"Total dimension of the array: {x.Rank}");

            Console.WriteLine("Performing sorting operation...");
            Array.Sort(x);
            Console.WriteLine("Sorted Array Elements: ");
            DisplayLinearArray(x);

            Console.WriteLine("Sorted Array Elements (Descending order): ");
            Array.Reverse(x);
            DisplayLinearArray(x);

        }
    }
}
