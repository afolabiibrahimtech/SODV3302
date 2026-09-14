namespace PersonProject
{
    class Person //internal class
    {
        //state vriables
       public string Name;
       public int Age;
       public string Profession;

        //behaviors
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Profession: {Profession}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Name = "Ibrahim Afolabi";
            p.Age = 29;
            p.Profession = "Teacher";

            p.Display();
        }
    }
}
