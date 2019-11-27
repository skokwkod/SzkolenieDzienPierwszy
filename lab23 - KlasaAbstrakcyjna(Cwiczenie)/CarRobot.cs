using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23___KlasaAbstrakcyjna_Cwiczenie_
{
    class CarRobot : Robot
    {
        public override string GiveName()
        {
            return "carRobot";
        }
        public override string Work()
        {
            return "Produkuje samochody";
        }
    }
}
