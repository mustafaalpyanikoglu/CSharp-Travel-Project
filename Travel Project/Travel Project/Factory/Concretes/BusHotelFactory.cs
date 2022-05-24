using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class BusHotelFactory : ITravelFactory
    {
        //Ulaşım olarak otobüs, konaklama olarak da oteli belirlediğimiz seyehat ürünü
        private Bus bus { get; set; }
        private Hotel hotel { get; set; }

        public BusHotelFactory(Bus bus, Hotel hotel)
        {
            //Oluşturduğumuz konaklama ve ulaşım'ı fabrikaya atıyoruz
            this.bus = bus;
            this.hotel = hotel;
        }

        public override IAccomodation createAccomodation()
        {
            //Konaklama yeri oluşturuyoruz
            return this.hotel;
        }

        public override ITransportation createTransportation()
        {
            //Ulaşım için araç oluşturuyoruz
            return this.bus;
        }
    }
}
