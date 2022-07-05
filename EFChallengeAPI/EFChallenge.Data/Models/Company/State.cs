using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Company
{
    public class State
    {
        public int Id { get; set; }
        
      
        public string Name { get; set; } = null!;
        
       
        public int CountryId { get; set; }

    }
}