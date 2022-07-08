using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Company
{
    public class Address
    {
        public int Id { get; set; } = 0;

        [Required, StringLength(300)]
        public string Line1 { get; set; } = null!;

        [StringLength(300)]
        public string? Line2 { get; set; }

        [StringLength(25)]
        public string ZipPostalCode { get; set; } = null!;

        [StringLength(150)]
        public string City { get; set; } = null!;
        public int CountyId { get; set; }
        public int AddressTypeId { get; set; }

        public County County { get; set; } = null!;

    }
}