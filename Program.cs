using System;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int i, string Title, string Author)
        {
            _Id = i;
            _Title = Title;
            _Author = Author;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetId(int identification)
        {
            _Id = identification;
        }

        public string GetTitle()
        {
            return _Title + " ";
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetAuthor()
        {
            return _Author + " ";
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public int GetTrans()
        {
            return _transactions;
        }

        public void SetTrans()
        {
            _transactions++;
        }

    }
    class myStore
    {
        static void Main(string[] args)
        {
            Book member10 = new Book();
            member10.SetTrans();
            member10.SetId(10);
            member10.SetTitle("The Hunger Games");
            member10.SetAuthor("Suzanne Collins");

            Book member20 = new Book();
            member20.SetTrans();
            Console.WriteLine("Please enter the member ID: ");
            member20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title: ");
            member20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author: ");
            member20.SetAuthor(Console.ReadLine());

            Book member30 = new Book(30, "Harry Potter and the Sorcerer's Stone", "J.K. Rowling");
            member30.SetTrans();

            Console.WriteLine("Please enter the member ID: ");
            int tempId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            Book member40 = new Book(tempId, tempTitle, tempAuthor);
            member40.SetTrans();

            Console.WriteLine($"Transactions = {member10.GetTrans()}");
            displayBooks(member10);
            displayBooks(member20);
            displayBooks(member30);
            displayBooks(member40);
        }
        static void displayBooks(Book member)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Member ID: {member.GetId()}");
            Console.WriteLine($"Title: {member.GetTitle()}");
            Console.WriteLine($"Author: {member.GetAuthor()}");
        }


    }
}

