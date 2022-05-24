using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class HTMLReportBuilder : IReportBuilder
    {
        public HTMLReportBuilder(Travel travel) : base(travel)
        {
        }

        public override string BuildContents() //Raporun orta kısmını oluşturuyouz
        {
            string result = $"<h3> Transportation Info: </h3>" +
                $"<p>Transportation is window side: <b>{(travel.transportation.IsWindowSide ? "Yes":"No")}</b></p><br>" +
                $"<p>Transportation luggage capacity: <b>{travel.transportation.LuggageCapacity}</b></p><br>"+
                $"<p>Transportation date: <b>{travel.transportation.Date.ToString("dd'-'MM'-'yyyy")}</b></p><br>" +
                $"<p>Transportation Price: <b>{travel.transportation.Price}</b></p><br>"+
                $"<h3> Accomodation Info: </h3>" +
                $"<p>Accomodation Capacity: <b>{travel.accomodation.Capacity}</b><p>"+
                $"<p>Accomodation Date: <b>{travel.accomodation.Date.ToString("dd'-'MM'-'yyyy")}</b><p>" +
                $"<p>Accomodation Price: <b>{travel.accomodation.Price}</b><p>";
            return result;
        }

        public override string BuildFooter() //Raporun son kısmını oluşturuyouz
        {
            string result = $"<h3>Total Price: <b>{travel.transportation.Price + travel.accomodation.Price}<b></h3>";
            return result;
        }

        public override string BuildHeader() //Raporun baş kısmını oluşturuyouz
        {
            string result = $"<h2>{travel.person.Name} {travel.person.Surname}'s info </h2><br>" +
                $"<h4>Age: {travel.person.Age}</h4><br>" +
                $"<h4>Identity Number: {travel.person.IdentityNumber}</h4><br>"+
                $"<h4>Phone Number: {travel.person.PhoneNumber}</h4><br>" +
                $"<h4>Email: {travel.person.Email}</h4><br>" +
                $"<h4>Address: {travel.person.Address}</h4><br>" ;
            return result;
        }
    }
}
