namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for Ref
            int number = 3;
            Console.WriteLine($"Before Increase: {number}");
            int increasedNum = ParameterDemo.Increase(ref number);
            Console.WriteLine($"After Increase: {increasedNum}");

            //for Out
            string nameOut = ParameterDemo.GetFullName(out string fullName);
            Console.WriteLine($"GetFullName: {fullName}");

            //for sumAll
            int totalSum = ParameterDemo.SumAll(1, 3, 5, 7, 11);
            Console.WriteLine($"Sum of all numbers: {totalSum}");
        }
    }
}