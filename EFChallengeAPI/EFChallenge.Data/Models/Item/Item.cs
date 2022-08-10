//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------
namespace EFChallenge.Data.Models.Item
{
    /// <summary>
    /// Class Item
    /// </summary>
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int ItemTypeId { get; set; }
        public int ItemStatusId { get; set; }
        public int ItemSubTypeId { get; set; }
        public int? LocationId { get; set; }
        public Guid? ParentItemId { get; set; }

        //Navigation Properties
        public ItemType ItemType { get; set; } = null!;
        public ItemSubType? ItemSubType { get; set; } = null!;
        public ItemStatus ItemStatus { get; set; } = null!;
        public Item? ParentItem { get; set; } = null!;
        public ItemIdentifier? ItemIdentifier { get; set; } = null!;
    }
}