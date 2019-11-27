using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23___KlasaAbstrakcyjna_Cwiczenie_
{
    class TrainRobot : Robot
    {
        public override string GiveName()
        {
            return "TrainRobot";
        }

        public override string Work()
        {
            return "Robot produkujacy pociagi";
        }
    }
}
