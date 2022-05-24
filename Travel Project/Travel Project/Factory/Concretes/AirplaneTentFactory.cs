using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class AirplaneTentFactory : ITravelFactory
    {
        //Ulaşım olarak uçak, konaklama olarak da çadırı belirlediğimiz seyehat ürünü
        private Tent tent { get; set; }
        private Airplane airplane { get; set; }

        public AirplaneTentFactory(Airplane airplane, Tent tent)
        {
            //Oluşturduğumuz konaklama ve ulaşım'ı fabrikaya atıyoruz
            this.airplane = airplane;
            this.tent = tent;
        }
        public override IAccomodation createAccomodation()
        {
            //Konaklama yeri oluşturuyoruz
            return this.tent;
        }

        public override ITransportation createTransportation()
        {
            //Ulaşım için araç oluşturuyoruz
            return this.airplane;
        }
    }
}
