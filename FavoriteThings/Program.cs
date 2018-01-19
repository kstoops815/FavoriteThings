using System;
using System.Collections.Generic;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var favBook = new Book { BookName = "Odd Thomas", Author = "Dean Koontz" };
            //var bookAuthor = new Book { Author = "Dean Koontz" };
            Console.WriteLine($"{favBook.BookName} is one of my favorite books!\n{favBook.Author} is the author.");

            var favMovie = new Movie { MovieName = "Pitch Perfect" };
            Console.WriteLine($"{favMovie.MovieName} is my favorite movie!");

            var favDrink = new Drink { DrinkName = "Diet Coke" };
            Console.WriteLine($"My favorite drink is {favDrink.DrinkName}.");

            var hobbies = new List<Hobby>
            {
                new Hobby { ThingToDo = "sewing", Crafty = true },
                new Hobby { ThingToDo = "bowling", Crafty = false },
                new Hobby { ThingToDo = "scrapbooking", Crafty = true },
                new Hobby { ThingToDo = "fantasy football", Crafty = false },
            };

            foreach (var hobby in hobbies)
            {
                Console.WriteLine($"{hobby.ThingToDo} is {(hobby.Crafty ? "crafty." : "not crafty.")}");
                Console.WriteLine(hobby.TheHobbyIsCrafty());
            }
        }
    }
}

 