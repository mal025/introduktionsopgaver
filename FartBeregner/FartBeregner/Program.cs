namespace FartBeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast KM: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Indtast minutter: ");
            double minut = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double hastighed = km * (minut/60);
            Console.WriteLine($"Hastigheden er {hastighed} km/t");

        }
    }
}
