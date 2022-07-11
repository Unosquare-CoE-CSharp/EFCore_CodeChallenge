//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------
namespace EFChallenge.Data.Models.Item
{
    /// <summary>
    /// Class ItemType
    /// </summary>
    public class ItemType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ItemContainerConstraint ItemContainerConstraint { get; set; } = null!;
    }

}