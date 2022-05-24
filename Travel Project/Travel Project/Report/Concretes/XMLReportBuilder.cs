using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class XMLReportBuilder : IReportBuilder
    {
        public XMLReportBuilder(Travel travel) : base(travel)
        {
        }

        public override string BuildContents() //Raporun orta kısmını oluşturuyouz
        {
            string result = $"<Transportation>" +
                $"<WindowSide>{(travel.transportation.IsWindowSide ? "Yes" : "No")}</WindowSide>" +
                $"<LuggageCapacity>{travel.transportation.LuggageCapacity}</LuggageCapacity>"+
                $"<Date>{travel.transportation.Date.ToString("dd'-'MM'-'yyyy")}</Date>" +
                $"<Price>{travel.transportation.Price}</Price>" +
                $"</Transportation>"+
            $"<Accomodation>" +
               $"<Capacity>{travel.accomodation.Capacity}</Capacity>" +
               $"<Date>{travel.accomodation.Date.ToString("dd'-'MM'-'yyyy")}</Date>" +
               $"<Price>{travel.accomodation.Price}</Price>" +
               $"</Accomodation>";
            return result;
        }

        public override string BuildFooter() //Raporun son kısmını oluşturuyouz
        {
            string result = $"<Footer>{travel.transportation.Price + travel.accomodation.Price}</Footer>";
            return result;
        }

        public override string BuildHeader() //Raporun baş kısmını oluşturuyouz
        {
            string result = $"<Header>" +
                $"<Person name='{travel.person.Name}' surname='{travel.person.Surname}'/>" +
                $"<Age>{travel.person.Age}'</Age>" +
                $"<IdentityNumber>{travel.person.IdentityNumber}'</IdentityNumber>" +
                $"<PhoneNumber>{travel.person.PhoneNumber}'</PhoneNumber>" +
                $"<Email>{travel.person.Email}'</Email>" +
                $"<Address>{travel.person.Address}'</Address>" +
                $"</Header>";
            return result;
        }
    }
}
