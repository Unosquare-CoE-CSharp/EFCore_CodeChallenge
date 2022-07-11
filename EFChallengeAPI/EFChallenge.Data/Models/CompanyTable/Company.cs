//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Company
{

    /// <summary>
    /// Class Company
    /// </summary>
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public CompanyAddress CompanyAddress { get; set; } = null!;

    }
}