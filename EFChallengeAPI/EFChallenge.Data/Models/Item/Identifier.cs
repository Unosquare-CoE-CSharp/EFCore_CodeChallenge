namespace EFChallenge.Data.Models.Item
{
    public class Identifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Data { get; set; } = null!;
    }

}