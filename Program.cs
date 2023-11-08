namespace Topic_4._5_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to view art.");
            Console.ReadLine();
            DrawSpeeder();
            Console.WriteLine();
            Console.WriteLine("Knock knock");
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("Chickens");
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("No, Owls make that sound. Chickens cluck");
        }

        public static void DrawSpeeder()
        {
            Console.WriteLine("              ____==========_______");
            Console.WriteLine("   _--____   |    | \"\"  \" \"|       \\");
            Console.WriteLine("  /  )8}  ^^^| 0  |  =     |  o  0  |");
        }
    }
}