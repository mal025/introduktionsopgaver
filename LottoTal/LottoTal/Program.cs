namespace LottoTal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] lottotal = { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 8; i++)
            {
                lottotal[i] = random.Next(1,36);
            }

            Array.Sort(lottotal);

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{lottotal[i]} ");
            }
        }
}
}