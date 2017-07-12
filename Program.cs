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
            List<string> favfoods = new List<string> { "Steak", "Fish", "Katsudon", "Ice cream", "Nachos" };

            if(favfoods.Contains("Fish"))
            {
                Console.WriteLine("I Like fish too!!");
            }




        }
    }
}
