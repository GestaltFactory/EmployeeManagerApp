namespace EmployeeClassLibrary.Models
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public int? AppartmentNumber { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }

        public Address(){}
    }
}