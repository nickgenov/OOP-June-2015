using System;
using System.Text;

namespace BookShopExercise
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Title", "Title cannot be null.");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Author", "Author cannot be null.");
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price cannot be a negative number.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);

            result.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);

            result.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);

            result.AppendFormat("-Price: {0:F2}", this.Price);

            return result.ToString();
        }
    }
}