//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.Data.Models.Item
{
    /// <summary>
    /// Class ItemAddendum
    /// </summary>
    public class ItemAddendum
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public string KeyField { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}