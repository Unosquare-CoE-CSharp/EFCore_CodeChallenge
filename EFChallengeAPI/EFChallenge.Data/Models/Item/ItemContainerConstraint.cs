using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Item
{
    public class ItemContainerConstraint
    {
        public int Id { get; set; }
        public int ItemTypeId { get; set; }
        
        public int Min { get; set; } = 0;
        
        
        public int Max { get; set; } = 0;
    }
}