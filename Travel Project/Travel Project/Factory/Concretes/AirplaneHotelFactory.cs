using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class AirplaneHotelFactory : ITravelFactory
    {
        //Ulaşım olarak uçak, konaklama olarak da oteli belirlediğimiz seyehat ürünü
        private Hotel hotel { get; set; }
        private Airplane airplane { get; set; }


        public AirplaneHotelFactory( Airplane airplane, Hotel hotel)
        {
            //Oluşturduğumuz konaklama ve ulaşım'ı fabrikaya atıyoruz
            this.hotel = hotel;
            this.airplane = airplane;
        }
        public override IAccomodation createAccomodation()
        { 
            //Konaklama yeri oluşturuyoruz
            return this.hotel;
        }

        public override ITransportation createTransportation()
        {
            //Ulaşım için araç oluşturuyoruz
            return this.airplane;
        }
    }
}
