namespace BankAccountApp.Models.DomainModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }

    }
}
