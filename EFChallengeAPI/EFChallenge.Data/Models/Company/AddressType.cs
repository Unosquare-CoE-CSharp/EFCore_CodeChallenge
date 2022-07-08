using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Company
{
    public class AddressType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}