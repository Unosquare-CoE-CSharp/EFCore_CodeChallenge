using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.DTOs.ItemDTOs
{
    public class ItemDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int ItemTypeId { get; set; }
        public int ItemStatusId { get; set; }
        public int ItemSubTypeId { get; set; }
        public int? LocationId { get; set; }
        public Guid? ParentItemId { get; set; }
    }
}
