using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Item
{
    //Changed min and max to unsigned int because you can't have negative quantities of physical objects
    public class ItemContainerConstraint
    {
        public int Id { get; set; }
        public int ItemTypeId { get; set; }

        [Range(0, int.MaxValue)]
        public uint Min { get; set; } = 0;

        [Range(0, int.MaxValue)]
        public uint Max { get; set; } = 0;
    }
}