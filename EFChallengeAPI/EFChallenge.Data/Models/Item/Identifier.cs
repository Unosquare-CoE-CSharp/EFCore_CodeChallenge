using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Item
{
    public class Identifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(500)]
        public string Data { get; set; } = null!;
    }

}