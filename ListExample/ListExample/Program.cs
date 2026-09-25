namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> myIntList = new List<int>();
            List<int> myIntList = new List<int>() { 11, 21, 13, 41, 5, 21, 21, 1, 21 };

            /*
            for (int i = 0; i < myIntList.Count; i++)
            {
                Console.Write(myIntList[i]+" ");
            }
            */

            Console.WriteLine("Initial List elements: ");
            Console.WriteLine(string.Join(" ", myIntList));

            Console.WriteLine("\nAdding 100 at the end of the list:");
            myIntList.Add(100); //100 will be added at the end of the list
            Console.WriteLine(string.Join(" ", myIntList));

            Console.WriteLine("\nInserting 7 at index 2:");
            myIntList.Insert(2, 7);  //Inserted 7 at index 2
            Console.WriteLine(string.Join(" ", myIntList));

            Console.WriteLine("\nRemoving first occurance of 21:");
            myIntList.Remove(21);  //removed first occurance of 21
            Console.WriteLine(string.Join(" ", myIntList));

            Console.WriteLine("\nRemoving all occurances of 21: ");
            myIntList.RemoveAll(e => e == 21);  //removed all occurance of 21
            Console.WriteLine(string.Join(" ", myIntList));

            myIntList.Reverse();
            Console.WriteLine("\nElements of the reverse list: ");
            Console.WriteLine(string.Join(" ", myIntList));

            myIntList.Sort();
            Console.WriteLine("\nSorted elements of the list: ");
            Console.WriteLine(string.Join(" ", myIntList));

        }
    }
}
