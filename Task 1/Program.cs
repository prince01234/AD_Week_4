namespace Task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Prince Shrestha";
            student1.Age = 21;
            student1.Email = "princeshrestha@gmail.com";

            Student student2 = new Student();
            student2.Name = "Stacy Rose";
            student2.Age = 21;
            student2.Email = "stacy.rose@email.com";

            PrintStudent(student1);
            PrintStudent(student2);
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Email: " + student.Email);
            Console.WriteLine("University: " + Student.University);
            Console.WriteLine();
        }
    }
}
