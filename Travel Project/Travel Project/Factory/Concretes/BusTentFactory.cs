using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class BusTentFactory : ITravelFactory
    {
        //Ulaşım olarak otobüs, konaklama olarak da çadırı belirlediğimiz seyehat ürünü
        private Bus bus { get; set; }
        private Tent tent { get; set; }

        public BusTentFactory(Bus bus, Tent tent)
        {
            //Oluşturduğumuz konaklama ve ulaşım'ı fabrikaya atıyoruz
            this.bus = bus;
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
            return this.bus;
        }
    }
}
