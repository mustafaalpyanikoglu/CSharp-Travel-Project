using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    abstract class IReportBuilder
    {
        protected Travel travel;

        public IReportBuilder(Travel travel)
        {
            this.travel = travel;
        }

        public string BuildResult()
        {
            //Rapor'u oluşturuyoruz
            string result = BuildHeader();
            result += BuildContents();
            result += BuildFooter();
            return result;
        }
        //Raporu soyutluyoruz
        public abstract string BuildHeader(); //Raporun baş kısmı
        public abstract string BuildFooter(); //Raporun son kısmı
        public abstract string BuildContents(); //Raporun orta kısmı
    }
}
