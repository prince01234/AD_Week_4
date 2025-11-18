namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.PrintWelcome();

            int sum = Calculator.Add(20, 30);
            Console.WriteLine($"Their sum is: {sum}");

            int product = Calculator.Multiply(10, null);
            Console.WriteLine($"Their product is: {product}");
        }
    }
}
