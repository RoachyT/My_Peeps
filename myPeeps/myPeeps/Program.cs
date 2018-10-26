using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPeeps
{
    class Program
 
    {
        //order is string firstName, string lastName, int age, string emailAddress, 
        static List<Person> people = new List<Person>()
        { new Person("Rochelle","Toles",26,"shellytoles@yahoo.com"),
        new Person ("Steven", "Smith", 54, "stevesmith@emailhub.com")};
        static void Main(string[] args)
        {
            whichWay();
            
        }

        static void whichWay()

        {
            try
            {

           
            Console.WriteLine("Would you like to add a person? Press 1");
            Console.WriteLine("If you want to view the list Press 2");
            Console.WriteLine("Wanna GTFO/BRB BRO? Hit that 3");
            int choosePath = int.Parse(Console.ReadLine());
            if (choosePath == 1)
            {
                //add student
                AddPerson();

            }
            else if (choosePath == 2)
            {// print list
                PrintMe();

            }
            else if (choosePath == 3)
            {
                //leave 
                Console.WriteLine("Peace");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please choose a real number");
                whichWay();
            }
            }
            catch (FormatException)
            {

                Console.WriteLine("What is wrong with you");
                whichWay();
            }

            void PrintMe()
            {
                foreach (Person p in people)
                {
                    Console.WriteLine(p.getList());
                    Console.WriteLine();
                }
            }

             void AddPerson()
            {
                
                Console.WriteLine("Would you like to add a person? y/n");
                string addStudinput = Console.ReadLine().ToLower();

                if (addStudinput == "yes" || addStudinput == "y")
                {
                    //order is string firstName, string lastName, int age, string emailAddress, bool isAnAdult
                    Console.WriteLine("What is the persons first name?");
                    string studFirstNameInput = Console.ReadLine();
   
                    Console.WriteLine($"What is the {studFirstNameInput}'s Last name?");
                    string studLastNameInput = Console.ReadLine();

                    Console.WriteLine($"What is {studFirstNameInput}\'s email address?");
                    string studAddressInput = Console.ReadLine();

                    Console.WriteLine($"What is {studFirstNameInput}\'s age");
                    int studageInput = int.Parse(Console.ReadLine());

                    if (Person.AreYouOldEnough(studageInput))
                    {
                        people.Add(new Person(studFirstNameInput, studLastNameInput, studageInput, studAddressInput));
                        Console.WriteLine($"{studFirstNameInput} has been added successfully!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry we don't add minors to this list");
                    }
                    
                    whichWay();

                }
                else if (addStudinput == "no" || addStudinput == "n")
                {
                    whichWay();
                }
                else
                {
                    Console.WriteLine("That was nonsense, again");
                    AddPerson();
                }

            }
            Looper();

        }
        static void Looper()
        {
            Console.WriteLine("Continue? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "yes" || goAgain == "y")
            {
                whichWay();
            }
            else if (goAgain == "no" || goAgain == "n")
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("That was pure nonsense");
                Looper();
            }
        }
    }
}
