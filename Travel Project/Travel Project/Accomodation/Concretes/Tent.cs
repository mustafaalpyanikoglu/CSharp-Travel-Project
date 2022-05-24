using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class Tent: IAccomodation
    {
        static public Tent[] TentList = {
            //Yeni çadır ekliyoruz
            new Tent(DateTime.Now,3,1500,true),
            new Tent(DateTime.Now, 4, 2500, true),
            new Tent(DateTime.Now, 5, 2000, false)
        };
        //çadıra özel özellikler
        public bool IsWaterProof { get; set; }

        public Tent(DateTime Date, int Capacity, double Price, bool IsWaterProof): base(Date, Capacity,Price)
        {
            //Konaklama bilgilerinin özelliklerini oluşturur
            this.IsWaterProof = IsWaterProof;

        }
    }
}
