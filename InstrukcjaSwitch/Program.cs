using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string komunikat = "";

            switch (DateTime.Now.AddDays(2).DayOfWeek.ToString())
            {
                case "Monday":
                    komunikat = "Poniedzialek";
                    break;
                case "Tuesday":
                    komunikat = "Wtorek";
                    break;
                case "Wednesday":
                    komunikat = "Środa";
                    break;
                case "Thursday":
                    komunikat = "Czwartek";
                    break;
                case "Friday":
                    komunikat = "Piątek";
                    break;
                case "Saturday":
                    komunikat = "Sobota";
                    break;
                case "Sunday":
                    komunikat = "Niedziela";
                    break;

                default:
                    komunikat = "default";
                    break;
            }

            Console.WriteLine(DateTime.Now.DayOfWeek+" "+komunikat);
            
            
            
            
            
            
            
            Console.ReadKey();
        }

    }
}
