//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.DTOs.ItemDTOs
{
    /// <summary>
    /// Class ItemDto
    /// This class is a DTO of Item
    /// </summary>
    public class ItemDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Item Type Id
        /// </summary>
        public int ItemTypeId { get; set; }

        /// <summary>
        /// Item Status Id
        /// </summary>
        public int ItemStatusId { get; set; }

        /// <summary>
        /// Item SubType Id
        /// </summary>
        public int ItemSubTypeId { get; set; }

        /// <summary>
        /// Location Id
        /// </summary>
        public int? LocationId { get; set; }

        /// <summary>
        /// Parent Item Id
        /// </summary>
        public Guid? ParentItemId { get; set; }
    }
}
