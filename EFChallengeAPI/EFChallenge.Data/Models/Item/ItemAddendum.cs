using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Item
{
    public class ItemAddendum
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        [StringLength(50)]
        public string KeyField { get; set; } = null!;
        
        [StringLength(500)]
        public string Value { get; set; } = null!;
    }
}