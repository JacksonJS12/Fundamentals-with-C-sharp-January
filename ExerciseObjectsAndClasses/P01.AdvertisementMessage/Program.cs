using System;
using System.Collections.Generic;

namespace P01.AdvertisementMessage
{
    
    internal class Program
    {
        class Phrases
        {
            
        }
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>()
            {
               "Excellent product.",
               "Such a great product.",
               "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.", 
                "I can’t live without this product."
            };

            List<string> events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };

            List<string> authors = new List<string>()
            {
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva"
            };
            List<string> cities = new List<string>()
            {
               "Burgas.", 
                "Sofia.", 
                "Plovdiv.", 
                "Varna.", 
                "Ruse."
            };


            Random random = new Random();
            int indexOfPhrases = random.Next(phrases.Count);
            int indexOfEvents = random.Next(events.Count);
            int indexOfAuthours = random.Next(authors.Count);
            int indexOfCities = random.Next(cities.Count);

            Console.Write($"{phrases[indexOfPhrases]} ");
            Console.Write($"{events[indexOfEvents]} ");
            Console.Write($"{authors[indexOfAuthours]} ");
            Console.Write($"- {cities[indexOfCities]} ");



        }
    }
}
