using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    public abstract class IAccomodation
    {
        //Konaklama bilgilerini soyutlar
        public DateTime Date;
        public int Capacity;
        public double Price;

        public IAccomodation(DateTime date, int capacity, double price)
        {
            this.Date = date;
            this.Capacity = capacity;
            this.Price = price;
        }
    }
}
