using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23___KlasaAbstrakcyjna_Cwiczenie_
{
    public abstract class Robot
    {

        public virtual string GiveName()
        {
            return "Robot";
        }

        public abstract string Work();
    }
}
