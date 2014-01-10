using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList;

            Console.WriteLine("Please insert the Location of your Movies here below:");
            String moviePath = Console.ReadLine();

            while(true) {
                selectCase(menueOutput());
            }

        }

        static int movieCount(String path)
        {
            //Do the Calculation of the existing movies here and return it
            return 0;
        }

        static int menueOutput()
        {
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("|                                                                              |");
            Console.WriteLine("| 1. Fill out the Movie List                                                   |");
            Console.WriteLine("| 2. Show the Movie List                                                       |");
            Console.WriteLine("| 3. Save the Movie List to a *.txt file                                       |");
            Console.WriteLine("| 4. Export the Movie List to Excel                                            |");
            Console.WriteLine("| 5. Format the Movie File Names                                               |");
            Console.WriteLine("| 6. Search for a certain Movie                                                |");
            Console.WriteLine("| 7. Play a Movie from your List (Name or ID required)                         |");
            Console.WriteLine("|                                                                              |");
            Console.WriteLine("| 8. Edit Movie File Location                                                  |");
            Console.WriteLine("| 9. Edit Movie Player to Play the Files                                       |");
            Console.WriteLine("|______________________________________________________________________________|");
            Console.WriteLine("");
            Console.WriteLine("Please type the Number of the Menu point you want to access now: ");

            int menuIndex = Console.Read();
            
            while ((menuIndex > 9) || (menuIndex < 1))   {
               Console.WriteLine("Unfortunately we could not find a Menu to access with the Number you defined. Please retry.");
               menuIndex = Console.Read();
            }

            return menuIndex;
        }

        static void selectCase(int menuIndex)
        {

        }

        static void fillMovieList()
        {

        }

        static void printMovieList()
        {

        }

        static void saveMovieList()
        {

        }

        static void exportMovieList()
        {

        }
    }
}
