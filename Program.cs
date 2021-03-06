using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a new object from the class person
            Person User = new Person();
            
            User.FirstName = TakeInput("Your first name?");
            User.LastName = TakeInput("Your last name?");
            Console.WriteLine("Your full name is: " + User.FirstName + " " + User.LastName);

            User.DateOfBirth = Convert.ToDateTime(TakeInput("Your date of birth? (YYYY-MM-DD)"));
            
            if (User.IsOfAge) Console.WriteLine("You are of age!");
            else Console.WriteLine("You are not of age!");
            //gets and parses data used in bmi calculation
            User.Weight = double.Parse(TakeInput("Your weight? (kg)"));
            User.Heigth = double.Parse(TakeInput("Your height? (m)").Replace('.',','));
            Console.WriteLine("Your BMI is: " + User.BMI);


            Console.ReadLine();
        }

        static string TakeInput(string query)       //Function that makes sure an input isn't empty
        {
            Console.WriteLine(query);
            string Answer;
            while (true)
            {
                Answer = Console.ReadLine();
                if (Answer != string.Empty) break;
            }
                return Answer;
        }
       

    }
}
