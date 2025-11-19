namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mark: ");
            string markInput = Console.ReadLine();

            Console.WriteLine("Enter total marks: ");
            string totalMarksInput = Console.ReadLine();

            int marks, total;

            if(!int.TryParse(markInput, out marks))
            {
                Console.WriteLine("Invalid input for marks.");
                return;
            }

            if(!int.TryParse(totalMarksInput, out total))
            {
                Console.WriteLine("Invalid input for total marks.");
                return;
            }

            //before fixing error
            //double percentage = ((double)marks / total) * 100;

            double percentage = ((double)marks / total) * 100;
            Console.WriteLine($"Percentage: {percentage}%");

        }
    }
}
