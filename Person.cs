using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_övning_2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }

        public DateTime DateOfBirth { get; set; }

        public bool IsOfAge { get { return AgeCheck(DateOfBirth);  } }
        public bool AgeCheck(DateTime BDay)         //Function for checking age
        {
            if (DateTime.Now.Year - DateOfBirth.Year > 18)
            {
                return true;
            }
            else if (DateTime.Now.Year - DateOfBirth.Year == 18 && DateOfBirth.DayOfYear <= DateTime.Now.DayOfYear)
            {
                return true;
            }
            else return false;
        }
        public double Heigth { get; set; }

        public double Weight { get; set; }

        public double BMI { get { return Weight / Math.Pow(Heigth,2) ; } }
    }
}
