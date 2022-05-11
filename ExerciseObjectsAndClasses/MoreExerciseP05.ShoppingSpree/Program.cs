using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreExerciseP05.ShoppingSpree
{
    internal class Program
    {
        class Person
        {
            public Person(string name, int money)
            {
                this.Name = name;
                this.Money = money;
                
                
            }
            public string Name { get; set; }
            public int Money { get; set; }
            public List<Product> BagOfProducts { get; set; }

            public void AffordableOrNot(List<Product> bagOfProducts)
            {

            }
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

            string[] peopleInput = Console.ReadLine()
              .Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries)
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

                Person person = new Person(name, money);
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
        }
    }
}
