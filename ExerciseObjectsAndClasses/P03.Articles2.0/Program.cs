using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Articles2._0
{

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < countCommands; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = cmdArgs[0];
                string content = cmdArgs[1];
                string author = cmdArgs[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }
                string orderBy = Console.ReadLine();

               
                Console.WriteLine(string.Join(Environment.NewLine, articles));
            
        }
    }
}

