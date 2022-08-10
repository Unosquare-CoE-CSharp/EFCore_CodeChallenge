//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Company
{
    /// <summary>
    /// Class County
    /// </summary>
    public class County
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int StateId { get; set; }

        //Navigation Properties
        public State State { get; set; } = null!;
        public List<Address> Addresses { get; set; } = null!;

    }
}