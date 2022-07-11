//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Company
{
    /// <summary>
    /// Class CompanyAddress
    /// </summary>
    public class CompanyAddress
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int AddressId { get; set; }
        
        public  Company Company { get; set; } = null!;
        public  Address Address { get; set; } = null!;

    }
}
