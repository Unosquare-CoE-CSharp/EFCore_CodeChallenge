using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.DTOs.ItemDTOs
{
    public class ItemReportDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? TypeName { get; set; }

        public Guid ParentId { get; set; } = Guid.NewGuid();

        public string? ParentType { get; set; }

        public string? StatusName { get; set; }

        public Guid? IdentifierID { get; set; } = Guid.NewGuid();

        public string? IdentifierTypeName { get; set; }

        public string? Data { get; set; }    

        public string? ItemSubTypeName { get; set; }

    }
}
