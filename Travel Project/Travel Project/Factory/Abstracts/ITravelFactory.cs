using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    public abstract class ITravelFactory
    {
        public abstract ITransportation createTransportation(); //Yeni ulaşım oluşturur
        public abstract IAccomodation createAccomodation(); //Yeni konaklama oluşturur
    }
}
