using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    public class Person
    {
        //Kişi bilgileri
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        
        public Person(string name, string surname, string age, string identityNumber, string phoneNumber, string email, string address)
        {
            //Yeni kişinin veri üyelerini başlatıyoruz.
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.IdentityNumber = identityNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
        }
    }
}
