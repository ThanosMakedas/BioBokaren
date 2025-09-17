namespace BioBokaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            {
                //Konstanter
                const double STUDENT_DISCOUNT = 0.15;
                const string CURRENCY = "SEK";

                // Arrayer
                string[] movies = { "Fast and furious", "Avengers" };
                string[] showTimes = { "18:00", "20:00" };
                double[] basePrices = { 120.0, 100.0 };

                //Variabler
                int selectedMovie = -1;
                int selectedTime = -1;
                int ticketCount = 0;
                bool isStudent = false;

                //Visa filmer
                Console.WriteLine("BioBokaren");
                Console.WriteLine("Tillgängliga filmer:");
                for (int i = 0; i < movies.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {movies[i]} - Tid: {showTimes[i]} - Pris: {basePrices[i]} {CURRENCY}");
                }

                // Välj film
                Console.Write("Välj film (1-2): ");
                int.TryParse(Console.ReadLine(), out selectedMovie);
                selectedMovie -= 1;

                // Välj tid
                Console.Write("Välj tid (1-2): ");
                int.TryParse(Console.ReadLine(), out selectedTime);
                selectedTime -= 1;

                // Antal biljetter
                Console.Write("Antal biljetter: ");
                int.TryParse(Console.ReadLine(), out ticketCount);

                // Student?
                Console.Write("Är du student? (ja/nej): ");
                string svar = Console.ReadLine().ToLower();
                isStudent = svar == "ja";

                // Prisberäkning
                double pricePerTicket = basePrices[selectedMovie];
                double totalPrice = ticketCount * pricePerTicket;

                if (isStudent)
                {
                    totalPrice = totalPrice * (1 - STUDENT_DISCOUNT);
                }

                // Kvitto
                Console.WriteLine("Kvitto");
                Console.WriteLine("Film: " + movies[selectedMovie]);
                Console.WriteLine("Tid: " + showTimes[selectedTime]);
                Console.WriteLine("Biljetter: " + ticketCount);
                Console.WriteLine("Studentrabatt: " + (isStudent ? "Ja" : "Nej"));
                Console.WriteLine("Att betala: " + totalPrice + " " + CURRENCY);
            }
        }

    }
}

