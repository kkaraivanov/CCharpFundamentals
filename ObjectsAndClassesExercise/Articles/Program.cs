using System;
using System.Linq;
using System.Text;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int countCommands = int.Parse(Console.ReadLine());
            Article article = new Article(readArticle[0], readArticle[1], readArticle[2]);

            for (int i = 0; i < countCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAutho(commands[1]);
                        break;
                    case "Rename":
                        article.Rename(commands[1]);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    public class Article
    {
        private string Title { get; set; }
        string Content { get; set; }
        string Author { get; set; }
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAutho(string newAutho)
        {
            this.Author = newAutho;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Title} - {Content}: {Author}");
            return sb.ToString();
        }
    }
}
