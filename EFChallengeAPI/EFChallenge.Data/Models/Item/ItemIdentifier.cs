//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Item
{
    /// <summary>
    /// Class ItemIdentifier
    /// </summary>
    public class ItemIdentifier
    {
        public int Id { get; set; }
        public Guid? ItemId  { get; set; }
        public Guid ItemIdentifierId { get; set; }

        //Navigation Properties
        public Item? item { get; set; }
        public Identifier identifier { get; set; } = null!;


    }

}