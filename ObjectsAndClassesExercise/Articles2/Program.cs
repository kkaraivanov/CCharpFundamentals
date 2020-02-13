using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());
            Article article = new Article();

            for (int i = 0; i < countCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                article.Add(commands[0], commands[1], commands[2]);
            }

            string sortParameter = Console.ReadLine();
            article.SortArticles(sortParameter);
            Console.WriteLine(article.ToString());
        }
    }
    public class Article
    {
        struct Articles 
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; } 
        }
        private List<Articles> articles;
        public Article() { this.articles = new List<Articles>(); }
        public void Add(string title, string content, string author)
        {
            Articles art = new Articles();
            art.Title = title;
            art.Content = content;
            art.Author = author;
            articles.Add(art);
        }
        public void SortArticles(string param)
        {
            switch (param)
            {
                case "title":
                    articles.Sort((ferst, last) => ferst.Title.CompareTo(last.Title));
                    break;
                case "content":
                    articles.Sort((ferst, last) => ferst.Content.CompareTo(last.Content));
                    break;
                case "author":
                    articles.Sort((ferst, last) => ferst.Author.CompareTo(last.Author));
                    break;
            }
        }
        public override string ToString()
        {
            List<string> temp = new List<string>();
            foreach (var article in articles)
            {
                string str = $"{article.Title} - {article.Content}: {article.Author}";
                temp.Add(str);
            }
            
            return string.Join("\n", temp);
        }
    }
}
