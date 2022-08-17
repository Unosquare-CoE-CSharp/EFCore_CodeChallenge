//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Company
{
    /// <summary>
    /// Class Country
    /// </summary>
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        //Navigation Properties
        public List<State>? States { get; set; }
    }
}