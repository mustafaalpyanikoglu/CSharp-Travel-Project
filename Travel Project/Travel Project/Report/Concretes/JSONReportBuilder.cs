using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class JSONReportBuilder : IReportBuilder
    {
        public JSONReportBuilder(Travel travel) : base(travel)
        {
        }

        public override string BuildContents() //Raporun orta kısmını oluşturuyouz
        {
            string result = "\"Transportation : \" { " +
                "\"window side\":" + (travel.transportation.IsWindowSide ? "Yes" : "No") + "," +
                "\"luggage capacity\":" + travel.transportation.LuggageCapacity + "," +
                "\"date\":" + travel.transportation.Date.ToString("dd'-'MM'-'yyyy") + "," +
                "\"price\":" + travel.transportation.Price + "}," +
                ",\"Accomodation\" : {" +
                "\"capacity\":" + travel.accomodation.Capacity + "," +
                "\"date\":" + travel.accomodation.Date.ToString("dd'-'MM'-'yyyy") + "," +
                "\"price\":" + travel.accomodation.Price + "},";
            return result;
        }

        public override string BuildFooter() //Raporun son kısmını oluşturuyouz
        {
            string result = "\"Total Price\": "+
                (travel.transportation.Price + travel.accomodation.Price).ToString()+
                " }";
            return result;
        }

        public override string BuildHeader() //Raporun baş kısmını oluşturuyouz
        {
            string result = "{ \"Person \": { " +
                "\"name \":" + travel.person.Name + "," +
                "\"age\":" + travel.person.Age + "," +
                "\"identity number\":" + travel.person.IdentityNumber + "," +
                "\"phone number\":" + travel.person.PhoneNumber + "," +
                "\"email\":" + travel.person.Email + "," +
                "\"address\":" + travel.person.Address + "}";

            return result;
        }
    }
}
