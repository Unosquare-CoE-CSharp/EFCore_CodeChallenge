//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Item
{
    /// <summary>
    /// Class ItemContainerConstraint
    /// </summary>
    public class ItemContainerConstraint
    {
        public int Id { get; set; }
        public int ItemTypeId { get; set; }
        
        [Range(0, int.MaxValue)]
        public int Min { get; set; } = 0;

        [Range(0, int.MaxValue)]
        public int Max { get; set; } = 0;
        public ItemType ItemType { get; set; } = null!;
    }
}