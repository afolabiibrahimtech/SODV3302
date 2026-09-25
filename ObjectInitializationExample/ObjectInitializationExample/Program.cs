namespace ObjectInitializationExample
{

    class Rectangle
    {
        public double Width;
        public double Height;


        public Rectangle()
        {

        }
        public Rectangle(double w, double h) //this is a parametric constructor
        {
            Width = w;
            Height = h;
        }

        public double GetArea()
        {
            return (Width * Height);
        }

        public override string ToString()
        {
            return $"Rectangle Object with Width: {Width}, Height: {Height}, Area: {GetArea()}.";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle(); //calling the default constructor
            Console.WriteLine(r);

            Rectangle r2 = new Rectangle(); //calling the default constructor followed by field initialization
            r2.Width = 10;
            r2.Height = 20;
            Console.WriteLine(r2);


            Rectangle r3 = new Rectangle { Width = 5, Height = 10 }; //C# initializer, that uses default constructor
            Console.WriteLine(r3);

            Rectangle r4 = new Rectangle(10, 4); //object creation by calling the parametric constructor
            Console.WriteLine(r4);

        }
    }
}
