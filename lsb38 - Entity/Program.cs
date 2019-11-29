using lsb38___Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsb38___Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            // AddBikes();

            using (var context = new RentBikeContext())
            {
                var bike = context
                    .Bikes
                    .Where(t => t.BikeType == "Town")
                    .FirstOrDefault();

                var rent = new Rent
                {
                    RentDate = DateTime.Now,
                    Bike = bike
                };
            }

        }

        private static void AddBikes()
        {
            List<Bike> bikes = new List<Bike>
            {
                new Bike { Number = "001", BikeType = "Mountain" },
                new Bike { Number = "002", BikeType = "Road" },
                new Bike { Number = "003", BikeType = "Town" },
                new Bike { Number = "004", BikeType = "Road" },
                new Bike { Number = "005", BikeType = "Mountain" },

            };

            using (var context = new RentBikeContext())
            {
                context.Bikes.AddRange(bikes);
                context.SaveChanges();
            }
        }
    }
}

