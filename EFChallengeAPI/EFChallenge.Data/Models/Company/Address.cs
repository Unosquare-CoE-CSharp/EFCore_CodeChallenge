using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Company
{
    public class Address
    {
        public int Id { get; set; } = 0;

        public string Line1 { get; set; } = null!;

        public string? Line2 { get; set; }

        public string ZipPostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public int CountyStateId { get; set; }
        public int AddressTypeId { get; set; }

    }
}