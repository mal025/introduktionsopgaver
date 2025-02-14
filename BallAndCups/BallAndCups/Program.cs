namespace BallAndCups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Vælg hvilket bæger du tror kuglen ligger i");
            Console.WriteLine("Tast 1, 2 eller 3 og tryk enter");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("     #");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     #");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     #");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("     1");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     2");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("     #");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     #");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     #");
            int cup = random.Next(1, 4);
            if (cup == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("     o");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("     x");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     x");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du vandt!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du tabte!");
                }
            }
            else if (cup == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("     x");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("     o");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     x");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du vandt!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du tabte!");
                }
            }
            else if (cup == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("     x");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("     x");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     o");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du vandt!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du tabte!");
                }
            }

        }
    }
}
