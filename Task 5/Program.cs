namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType daytype;

            if (day == "friday" || day == "saturday")
            {
                daytype = DayType.Weekend;
                Console.WriteLine("It is: Weekend");
            }
            else
            {
                daytype = DayType.Weekday;
                Console.WriteLine("It is: Weekday");
            }

            Book book0 = new Book("Lord of the Mysteries", "Yuan Ye (Cuttlefish That Loves Diving)", 10.00);

            Book book1 = book0 with { title = "Lord of the Mysteries: The Clown", price = 20.00 };
            Console.WriteLine(book0);

            var (title, author, price) = book1;
            Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");

        }
    }
}
