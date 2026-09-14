namespace CSProject
{
    class My
    {
        private int _x;
        int _y;
        int _sum;
        public void Input()
        {
            Console.WriteLine("Enter the first number");
            _x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            _y = int.Parse(Console.ReadLine());
        }
    }
    class test
    {

        static void Main()
        {
            Console.WriteLine("Enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x+"+"+y+"="+(x+y));  //string concatenated output
            Console.WriteLine("{0}+{1}={2}", x, y, (x + y)); //Parametric output
            Console.WriteLine($"{x}+{y}={x + y}");  //c# output this is readable and easier

           // MyClass obj =new MyClass();
        }
    }
}