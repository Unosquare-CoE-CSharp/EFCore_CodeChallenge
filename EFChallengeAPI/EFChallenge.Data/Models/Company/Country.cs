using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Company
{
    public class Country
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = null!;

        public List<State>? States { get; set; }
    }
}