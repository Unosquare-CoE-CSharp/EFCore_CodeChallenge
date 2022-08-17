//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Company
{
    /// <summary>
    /// Class AddressType
    /// </summary>
    public class AddressType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        //Navigation Properties
        public List<Address>? Addresses { get; set; }
    }
}