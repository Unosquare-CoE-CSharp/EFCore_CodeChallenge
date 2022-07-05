using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Company
{
    public class County
    {
        public int Id { get; set; }

     
        public string Name { get; set; } = null!;

        
        public int StateId { get; set; }
    }
}