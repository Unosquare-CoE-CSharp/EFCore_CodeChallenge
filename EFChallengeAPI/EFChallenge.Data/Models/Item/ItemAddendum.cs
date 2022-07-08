using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Item
{
    public class ItemAddendum
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        
        public string KeyField { get; set; } = null!;

        
        public string Value { get; set; } = null!;
    }
}