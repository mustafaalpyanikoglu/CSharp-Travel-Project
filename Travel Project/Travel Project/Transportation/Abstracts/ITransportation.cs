using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    public abstract class ITransportation
    {
        //Genel ulaşım bilgileri.
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public bool IsWindowSide { get; set; }
        public double LuggageCapacity { get; set; }
        public int TravelTime { get; set; }
        public ITransportation(double price, DateTime date, bool isWindowSide, double luggageCapacity, int travelTime)
        {
            //Ulaşım bilgisinin veri üyelerini başlatıyoruz
            this.Price = price;
            this.Date = date;
            this.IsWindowSide = isWindowSide;
            this.LuggageCapacity = luggageCapacity;
            this.TravelTime = travelTime;
        }
    }
}
