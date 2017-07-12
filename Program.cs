using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex: 1
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int numbers in favNumbers)
            //{
            //   // Console.WriteLine(numbers);
            //}
            ////use the count property to get the length of the list
            //Console.WriteLine(favNumbers.Count);
            //output is how many numbers that are listed

            // ex:2
            //List<string> books = new List<string> { "Cat in the hat", "Toad and frog", "Green eggs and ham" };
            //Console.WriteLine(books[0]);
            ////inserts at the current index moving the previous element down one
            //books.Insert(0, "Horton hears a who");
            //Console.WriteLine(books[0]);

            //creat a List and add 5 animals using the .Add()
            //print each animal in the list

            //create the following list:
            //a bool list {true, false,false,true,false}
            //loop through each value
            //if the value is true print "better bring an unbrella"
            //ifthe value is false print "no rain today enjoy the sun"

            //ex.3 list string
            //List<string> animals = new List<string>();
            //animals.Add("Lion");
            //animals.Add("tiger");
            //animals.Add("bear");
            //animals.Add("giraffe");
            //animals.Add("wolf");
            //for (int i = 0; i < animals.Count; i++) 

            //    {
            //    Console.WriteLine(animals[i]);
            //}

            //ex.4 bool list
            //List<bool> boolList = new List<bool> { true, false, false, true, false };


            //foreach (bool day in boolList)
            //{
            //    if (day == true)
            //    {
            //        Console.WriteLine("better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO rain today enjoy the sun");
            //    }
            //}

            //ex.5 .contains
            //List<string> favfoods = new List<string> { "Steak", "Fish", "Katsudon", "Ice cream", "Nachos" };

            //if(favfoods.Contains("Fish"))
            //{
            //    Console.WriteLine("I Like fish too!!");
            //}

            //ex 6.

            //create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            //use the contains method with the following values: 23 77 15
            // remove theses elements: 23 77 32 and 6 (look up the remove method)
            // use Contains() again on these value: 23 77 25

            //List<int> value = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //if (value.Contains(23))
            //{
            //    Console.WriteLine("Wrong");
            //}
            //if (value.Contains(1))
            //{
            //    Console.WriteLine("its on the list");
            //}
            //if (value.Contains(9))
            //{
            //    Console.WriteLine("its on the list");
            //}
            //if (value.Contains(77))
            //{
            //    Console.WriteLine("Wrong");
            //}
            //if (value.Contains(922))
            //{
            //    Console.WriteLine("its on the list");
            //}
            //if (value.Contains(6))
            //{
            //    Console.WriteLine("its on the list");
            //}
            //if (value.Contains(32))

            //    if (value.Contains(63))
            //        if (value.Contains(14))
            //            if (value.Contains(5))
            //            {
            //                Console.WriteLine("its on the list");
            //                value.Remove(23);
            //                value.Remove(77);
            //            }

            //create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            //use the contains method with the following values: 23 77 15
            // remove theses elements: 23 77 32 and 6 (look up the remove method)
            // use Contains() again on these value: 23 77 25


            //List<int> value = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(value.Contains(23));
            //Console.WriteLine(value.Contains(77));
            //Console.WriteLine(value.Contains(15));

            //value.Remove(23);
            //value.Remove(77);
            //value.Remove(32);
            //value.Remove(6);

            //Console.WriteLine(value.Contains(23));
            //Console.WriteLine(value.Contains(77));
            //Console.WriteLine(value.Contains(15));

            //**practice
            //ask the user for a movie
            Console.WriteLine("Welcome to Movie renter");
            List<string> movie = new List<string> { "Replacements", "Wedding Crashers", "Superman", "Avatar" };
            

            Console.WriteLine("Please enter a Movie that you would like to rent.");
            string movie1 = Console.ReadLine();

            if (movie.Contains(movie1))
            {
                Console.WriteLine("Your Movie is on its way.");
            }
            else
            {
                Console.WriteLine("That movie is not on the list, we will order that right away");
                movie.Add(newMovie);
                Console.WriteLine("We will add that movie right away");


                Console.WriteLine("Would you like to exit?");
                Console.ReadLine();



                //if the movie is not on the list add it
                //if the movie is on the list inform user that the movie is on the way
                //inform the user that the movie had been added
                //if the user enters quit the program should exit
                //the user should be able to add as many movies as they want
                //when the user quits show them all the movie are being ordered
            }
            
        }
    }
}
