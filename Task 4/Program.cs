namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Console.WriteLine("Player 1:");
            Console.WriteLine("Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            Console.WriteLine();

            // Create object using parameterized constructor
            Player p2 = new Player("Prince Shrestha", 999, 99999);
            Console.WriteLine("Player 2:");
            Console.WriteLine("Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);
        }
    }
}
