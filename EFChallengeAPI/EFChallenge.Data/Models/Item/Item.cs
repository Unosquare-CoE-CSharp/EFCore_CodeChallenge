namespace EFChallenge.Data.Models.Item
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int ItemTypeId { get; set; }
        public int ItemStatusId { get; set; }
        public int ItemSubTypeId { get; set; }
        public int LocationId { get; set; }
        public Guid? ParentItemId { get; set; }
        public Item? ParentItem { get; set; }
        public ItemType ItemType { get; set; } = null!;
        public ItemSubType? ItemSubType { get; set; } = null;
        public ItemStatus ItemStatus { get; set; } = null!;
    }
}