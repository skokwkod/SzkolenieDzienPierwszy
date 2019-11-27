using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23___KlasaAbstrakcyjna_Cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainRobot trainRobot = new TrainRobot();
            trainRobot.GiveName();
            Console.WriteLine(trainRobot.Name+ " " + trainRobot.Work());
            
            CarRobot carRobot = new CarRobot();
            carRobot.GiveName();
            Console.WriteLine(carRobot.Name+ " " + carRobot.Work());

            Console.ReadKey();
        }
    }
}
