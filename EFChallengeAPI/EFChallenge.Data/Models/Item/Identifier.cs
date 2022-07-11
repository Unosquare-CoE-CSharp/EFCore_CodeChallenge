//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Item
{
    /// <summary>
    /// Class Identifier
    /// </summary>
    public class Identifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Data { get; set; } = null!;

        //Foreign Id
        public int IdentifierTypeId { get; set; } 
        public IdentifierType IdentifierType { get; set; } = null!;

        //one to one
        public ItemIdentifier ItemIdentifier { get; set; } = null!;
    }

}