using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class Bus:ITransportation
    {
        static public Bus[] BusList = {
            //Yeni otobüs verilerini ekler ve oluştururuz
            new Bus(DateTime.Now, 500,true,20,3) ,
            new Bus(DateTime.Now, 1000,false,30,4) ,
            new Bus(DateTime.Now, 1500,true,40,2)
        };

        public Bus(DateTime dateTime, int price, bool isWindowSide, double luggageCapacity, int travelTime):base(price, dateTime,isWindowSide,luggageCapacity,travelTime)
        {
            //Uçak bilgilerinin genel özelliklerini oluşturuyoruz
        }
    }
}
