using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class Airplane:ITransportation
    {
        static public Airplane[] AirplaneList = {
            //Yeni uçak verilerini ekler ve oluştururuz
            new Airplane(DateTime.Now, 3000,true,20,3) ,
            new Airplane(DateTime.Now, 4000,false,30,4) ,
            new Airplane(DateTime.Now, 5000,true,40,2) 
        };

        public Airplane(DateTime dateTime,int price, bool isWindowSide, double luggageCapacity, int travelTime) :base(price,dateTime,isWindowSide,luggageCapacity,travelTime)
        {
            //Uçak bilgilerinin genel özelliklerini oluşturuyoruz
        }
    }
}
