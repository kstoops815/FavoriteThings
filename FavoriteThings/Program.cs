using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                BookName = "Odd Thomas"
            };
        }
    }

    class Book
    {
        protected string _bookName;
        protected string _author;

        public string BookName
        {
            get
            {
                return $"I love the book {_bookName}!";
            }
            set
            {
                _bookName = value;
            }
        }

        public string Author
        {
            get
            {
                return $"The author is {_author}.";
            }
            set
            {
                _author = value;
            }
        }
    }

    class Movie
    {
        protected string _movieName;
        protected string _movieYear;

        public string MovieName
        {
            get
            {
                return $"My favorite movie is {_movieName}!";
            }
            set
            {
                _movieName = value;
            }
        }

        public string MovieYear
        {
            get
            {
                return $"This movie was released in {_movieYear}.";
            }
            set
            {
                _movieYear = value;
            }
        }
    }
}
