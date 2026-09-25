namespace GenericListExample
{
    class Student
    {
        public string Name;
        public int ID;
        public double Gpa;

        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}, GPA: {Gpa}.";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> genericList = new List<Object>();
            genericList.Add(1); //adding an integer
            genericList.Add(3.14); //adding a double
            genericList.Add('A'); //adding a character
            genericList.Add("String"); //adding a string
            genericList.Add(new Student { Name = "Alex Whatmore", ID = 1234, Gpa = 3.99 }); //adding a student


            Console.WriteLine(string.Join("\n", genericList));





        }
    }
}
