using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Data.Models.Item
{
    public class ItemSubType
    {
        public int Id { get; set; }
       
        public string Name { get; set; } = null!;
    }
}
