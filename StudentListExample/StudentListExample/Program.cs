namespace StudentListExample
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
            Student tom = new Student { Name = "Tom Hanks", ID = 1234, Gpa = 4.0 };
            //Console.WriteLine(tom);

            Student susan = new Student { Name = "Susan Harper", ID = 1111, Gpa = 3.5 };

            Student alex = new Student { Name = "Alex Whatmore", ID = 1112, Gpa = 3.15 };

            Student david = new Student { Name = "David Alwright", ID = 1114, Gpa = 3.71 };

            List<Student> stuList = new List<Student>() { tom, susan };

            stuList.Add(alex);
            stuList.Insert(0, david);



            Console.WriteLine(string.Join("\n", stuList));


            Console.WriteLine("Enter a student name: ");
            string name = Console.ReadLine();
            name = name.Trim();
            name = name.ToLower();

            Student foundStudent = stuList.Find(s => s.Name.ToLower() == name);


            if (foundStudent == null)
            {
                Console.WriteLine("The student is not there in the list!");
            }
            else
            {
                Console.WriteLine("Here is the information we found: ");
                Console.WriteLine(foundStudent);
            }





        }
    }
}
