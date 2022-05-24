using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class Hotel : IAccomodation
    {
        static public Hotel[] HotelList = {
            //Yeni otel ekliyoruz.
            new Hotel(DateTime.Now, 4, 2302, 4,"ABC Hotel","ABC Mahallesi ABC Caddesi ABC/CBA"),
            new Hotel(DateTime.Now, 2, 4356, 2,"DEF Hotel","DEF Mahallesi DEF Caddesi DEF/FED"), 
            new Hotel(DateTime.Now, 3, 2342, 5,"GHI Hotel","GHI Mahallesi GHI Caddesi GHI/IHG") 
        };
        //Otel'e özel özellikler
        public int StarCount { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public Hotel(DateTime date,int capacity, double price,int starCount, string Name, string Address) : base(date,capacity,price)
        {
            //Otel bilgilerinin özelliklerini oluşturur
            this.StarCount = starCount;
            this.Name = Name;
            this.Address = Address;
        }
    }
    


}
