//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------
namespace EFChallenge.Data.Models.Company
{
    /// <summary>
    /// Class Address
    /// </summary>
    public class Address
    {
        public int Id { get; set; } = 0;

        public string Line1 { get; set; } = null!;

        public string? Line2 { get; set; }

        public string ZipPostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public int CountyId { get; set; }

        public County County { get; set; } = null!;
        public int AddressTypeId { get; set; }

        public AddressType AddressType { get; set; } = null!;
        public CompanyAddress CompanyAddress { get; set; } = null!;
    }
}