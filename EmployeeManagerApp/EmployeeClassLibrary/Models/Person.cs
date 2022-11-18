using System;
using System.Drawing;

namespace EmployeeClassLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }       
        public DateTime Dob { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }
        public Address Address { get; set; }

        #region Properties from Address for databinding
            public int StreetNumber { get { return Address.StreetNumber; } set { Address.StreetNumber = value; } }
            public string StreetName { get { return Address.StreetName; } set { Address.StreetName = value; } }
            public int? AppartmentNumber { get { return Address.AppartmentNumber; } set { Address.AppartmentNumber = value; } }
            public string Zipcode { get { return Address.Zipcode; } set { Address.Zipcode = value; } }
            public string Country { get { return Address.Country; } set { Address.Country = value; } }
            public string Province { get { return Address.Province; } set { Address.Province = value; } }
        #endregion

        public Person(){ Address = new Address(); }

        public virtual string WriteToEmployeeFile()
        {
            return $"{ Id },{ FirstName },{ LastName },{ MiddleName },{ Dob },{ Age },{ Gender },{ EmailAddress },{ CellphoneNumber },{ StreetNumber },{ StreetName },{ AppartmentNumber },{ Zipcode },{ Country },{ Province }";
        }
    }
}