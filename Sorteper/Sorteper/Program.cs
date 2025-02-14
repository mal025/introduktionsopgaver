namespace Sorteper
{
    internal class Program
    {
        private static string[] deck;
        private static List<string> myHand;
        private static List<string> computerHand;
        static void Main(string[] args)
        {
            init(); // initialiserer alle kort
            string[] shuffledDeck = shuffle(deck); // blander kort
            deal(); // giver kort ud til spilleren og computeren
            displayHands(); // Viser kort
            Thread.Sleep(1000);
            Console.WriteLine("Spillet tjekker eksisterende par");
            Console.WriteLine();
            Thread.Sleep(1000);
            findPair(myHand, "spiller");
            findPair(computerHand, "computer");
            Console.WriteLine();
            Thread.Sleep(1000);
            displayHands();
            startGame();
        }

        static void init() // initialisere kort
        {
            deck = new string[] { "Hare", "Hare", "Ko", "Ko", "Sorteper", "Kylling", "Kylling", "Hund", "Hund", "Kat", "Kat", "Fugl", "Fugl", "Haj", "Haj", "Hval", "Hval" };
        }
        static string[] shuffle(string[] deck) // Bruger Fisher-Yates shuffle algoritmen
        {
            Random random = new Random();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int j = random.Next(i+1); // Vælger et tilfældit indeks af arrayet fra o til i
                (deck[i], deck[j]) = (deck[j], deck[i]); // Bytter det tilfældige indeks med nuværende iteration af for loopet

            }
            return deck;
        }
        static void deal() // Uddeler kort til spilleren og computeren
        {
            List<string> myHandTemp = new List<string>(); // midlertidig liste som bliver sat på den normale efter, fik det til at virke på den her måde, ikke optimalt, men virker
            List<string> computerHandTemp = new List<string>();
            for (int i = 0; i < deck.Length; i++)
            {
                if (i % 2 == 0) // ved hver i som er lige får computeren et kort, og hvert ulige får spilleren
                {
                    computerHandTemp.Add(deck[i]);
                } 
                else
                {
                    myHandTemp.Add(deck[i]);
                }
            }
            myHand = myHandTemp;
            computerHand = computerHandTemp;
        }
        static void findPair(List<string> hand, string playerType) // finder par i en hånd og fjerner det fra hånden
        {
            bool pairFound = true;
            while (pairFound)
            {
                pairFound = false;
                for (int i = 0; i < hand.Count; i++)
                {
                    for (int j = i+1; j < hand.Count; j++)
                    {
                        if (hand[i] == hand[j])
                        {
                            Console.WriteLine($"Fandt et par med {hand[i]} i {playerType}'s hånd");
                            hand.RemoveAt(j);
                            hand.RemoveAt(i);
                            pairFound = true;
                            Thread.Sleep(500);
                            break;
                        }
                    }
                    if (pairFound)
                    {
                        break;
                    }
                }
            }
        }
        static void displayHands() // metode til at vise spiller og computers kort
        {
            Console.Write("Din hånd: ");
            Console.WriteLine(string.Join(", ", myHand));
            Thread.Sleep(1000);
            Console.Write("Computers hånd: ");

            for (int i = 0; i < computerHand.Count-1;i++)
            {
                Console.Write("???, ");
            }
            Console.WriteLine("???");
            Console.WriteLine();
        }
        static void startGame()
        {
            while (myHand.Count + computerHand.Count > 1)
            {
                myDraw();
                Thread.Sleep(2000);
                computerDraw();
            }
            if (myHand.Count == 0)
            {
                Console.WriteLine("Du vandt!");
            }
            else
            {
                Console.WriteLine("Computeren vandt!");
            }
        }
        static void myDraw()
        {
            Random random = new Random();
            Console.WriteLine("Din tur!");
            Console.Write($"Vælg et tal mellem 1 og {computerHand.Count}: ");
            int fakeChoice = int.Parse(Console.ReadLine());// Giver spilleren en illusion om det frie valg, findes det overhovedet?
            int choice = random.Next(computerHand.Count);
            myHand.Add(computerHand[choice]);
            Console.WriteLine($"Du valgte {computerHand[choice]}");
            computerHand.RemoveAt(choice);
            Thread.Sleep(1000);
            findPair(myHand, "spiller");
            Console.WriteLine();
            displayHands();
        }
        static void computerDraw()
        {
            Random random = new Random();
            Console.WriteLine("Computerens tur!");
            Thread.Sleep(1000);
            int choice = random.Next(myHand.Count);
            Console.WriteLine($"Computeren vælger {myHand[choice]}");
            computerHand.Add(myHand[choice]);
            myHand.RemoveAt(choice);
            Thread.Sleep(1000);
            findPair(computerHand, "computer");
            Console.WriteLine();
            displayHands();
            
        }

    }
}
