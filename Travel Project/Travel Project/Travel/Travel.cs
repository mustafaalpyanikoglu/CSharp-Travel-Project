using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    public class Travel
    {
        public IAccomodation accomodation;
        public ITransportation transportation;
        public Person person;
        public Travel(ITravelFactory travelFactory,Person person) // Parametre olarak fabrika alır ve eşitleme yapılır
        {
            this.accomodation = travelFactory.createAccomodation();
            this.transportation = travelFactory.createTransportation();
            this.person = person;
        }


    }
}
