using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            int count = int.Parse(Console.ReadLine());
            message.DisplayMessage(count);
        }
    }
    class Message
    {
        public void DisplayMessage(int count)
        {
            for (int i = 0; i < count; i++)
            {
                OutputMessage();
            }
        }
        private static void OutputMessage()
        {
            string[] phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] events = {"Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            string message = $"{phrases[Generator(phrases.Length)]} " +
                             $"{events[Generator(events.Length)]} " +
                             $"{authors[Generator(authors.Length)]} – " +
                             $"{city[Generator(city.Length)]}";

            Console.WriteLine(message);
        }
        private static int Generator(int count)
        {
            Random random = new Random();
            return random.Next(0, count);
        }
    }
}
