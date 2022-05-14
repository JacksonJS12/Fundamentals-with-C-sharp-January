using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreExerciseP05.ShoppingSpree
{
    internal class Program
    {
        class Person
        {
            public Person(string name, int money, List<string> bagOfProducts)
            {
                this.Name = name;
                this.Money = money;
                this.BagOfProducts = bagOfProducts;

            }
            public void CanPurchese(string personName, string productName)
            {
            
                if (this.Money - Cost< this.Money)
                {
                    this.Money -= Product.Cost;
                    this.BagOfProducts.Add(productName);
                    Console.WriteLine($"{personName} bought {productName}");
                    
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                    
                }
            }
            public string Name { get; set; }
            public int Money { get; set; }
            public List<string> BagOfProducts { get; set; }


        }
        class Product
        {
            public Product(string name, int cost)
            {
                this.Name = name;
                this.Cost = cost;
            }

            public string Name { get; set; }
            public int Cost { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            List<string> bagOfProducts = new List<string>();

            string[] peopleInput = Console.ReadLine()
              .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

            string[] productsInput = Console.ReadLine()
              .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

            for (int i = 0; i < peopleInput.Length; i++)
            {
                string[] personInput = peopleInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = personInput[0];
                int money = int.Parse(personInput[1]);
               
                Person person = new Person(name, money, bagOfProducts);
                people.Add(person);
            }

            for (int i = 0; i < productsInput.Length; i++)
            {
                string[] productInput = productsInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = productInput[0];
                int cost = int.Parse(productInput[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }

            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                string[] productToPurchase = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string personName = productToPurchase[0];
                string productName = productToPurchase[1];
                foreach (var person in people)
                {
                    if (person.Name == personName)
                    {
                        foreach (var product in products)
                        {
                            if (product.Name == productName)
                            {

                                
                            }
                        }
                        break;
                    }
                }
                cmd = Console.ReadLine();
            }
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
            }
        }
    }
}
