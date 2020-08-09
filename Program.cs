using System;
using System.Collections.Generic;
//using NUnit;



namespace Lab11ListObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 10 movies in this list.");

            List<Movie> movies = new List<Movie>()
            {
                new Movie("ex machina", "scifi"),
                new Movie("Snowpiercer", "scifi"),
                new Movie("Avatar", "scifi"),
                new Movie("American Beauty", "drama"),
                new Movie("Pleasantville", "drama"),
                new Movie("Pulp Fiction", "drama"),
                new Movie("Night of the Living Dead", "horror"),
                new Movie("The Shining", "horror"),
                new Movie("Shrek", "animated"),
                new Movie("Despicable Me", "animated")
            };

            do
            {
                var userCategory = MovieCategory();
                List<string> moviesSorted = new List<string>();

                Console.WriteLine();
                foreach (var movie in movies)
                {
                    if (movie.Category == userCategory)
                    {
                    moviesSorted.Add(movie.Title);
                    }
                }
                moviesSorted.Sort();

                moviesSorted.ForEach(delegate (String name)
                {
                    Console.WriteLine(name);
                });

            } while (ToContinue());

            //runTests();
        }

        public static string MovieCategory()
        {
            Console.WriteLine();
            Console.WriteLine("What category are you interested in? ");
            Console.WriteLine("Animated = 1");
            Console.WriteLine("Drama = 2");
            Console.WriteLine("Horror = 3");
            Console.WriteLine("SciFi = 4");
            bool getInput = true;
            do
            {
                Console.Write("Enter the number for the category you would like to see: ");
                var userInput = int.TryParse(Console.ReadLine(), out int categoryNum);
                if (userInput && categoryNum >=1 && categoryNum<=4)
                {
                    switch (categoryNum)
                    {
                        case 1:
                            return "animated";
                        case 2:
                            return "drama";
                        case 3:
                            return "horror";
                        case 4:
                            return "scifi";
                    }
                }
                else
                {
                    Console.WriteLine("Input not valid. Please enter a number 1 thru 4");
                }
            } while (getInput);
            return "Invalid";
        }


        public static bool ToContinue()
        {
            {
                bool proceed = true;
                while (proceed)
                {
                    Console.WriteLine();
                    Console.Write("Do you want to continue? (y/n): ");
                    var keepGoing = Console.ReadLine();
                    if (keepGoing.ToLower() == "n")
                    {
                        Console.WriteLine("Goodbye");
                        return false;
                    }
                    else
                    {
                        if (keepGoing.ToLower() == "y")
                        {
                            return true;
                        }
                        else
                        {
                            Console.Write("Invalid input - please enter y or n: ");
                        }
                    }
                }
            }
            return true;
        }

        
        //public static void runTests()
        //{
        //    List<Movie> moviesTest = new List<Movie>()
        //    {
        //        new Movie("ex machina", "scifi"),
        //        new Movie("Snowpiercer", "scifi"),
        //        new Movie("Avatar", "scifi"),
        //        new Movie("American Beauty", "drama"),
        //        new Movie("Pleasantville", "drama"),
        //        new Movie("Pulp Fiction", "drama"),
        //        new Movie("Night of the Living Dead", "horror"),
        //        new Movie("The Shining", "horror"),
        //        new Movie("Shrek", "animated"),
        //        new Movie("Despicable Me", "animated")
        //    };
        //    Assert.AreEqual(moviesTest[0].Title, "ex machina");
        //}
    }
}
