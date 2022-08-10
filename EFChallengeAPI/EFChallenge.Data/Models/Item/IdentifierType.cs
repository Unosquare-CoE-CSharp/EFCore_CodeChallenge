//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------
namespace EFChallenge.Data.Models.Item
{
    /// <summary>
    /// Class IdentifierType
    /// </summary>
    public class IdentifierType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        //Navigation Properties
        public List<Identifier>? Identifiers { get; set; } = null!;
    }    

}