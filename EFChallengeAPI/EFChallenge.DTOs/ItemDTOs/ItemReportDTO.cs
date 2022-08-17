//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

namespace EFChallenge.DTOs.ItemDTOs
{
    /// <summary>
    /// Class ItemReportDto
    /// This class is a DTO 
    /// </summary>
    public class ItemReportDTO
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Type Name
        /// </summary>
        public string? TypeName { get; set; }

        /// <summary>
        /// Parent Id
        /// </summary>
        public Guid ParentId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Parent Type
        /// </summary>
        public string? ParentType { get; set; }

        /// <summary>
        /// Status Name
        /// </summary>
        public string? StatusName { get; set; }

        /// <summary>
        /// Identifier ID
        /// </summary>
        public Guid? IdentifierID { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Identifier Type Name
        /// </summary>
        public string? IdentifierTypeName { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public string? Data { get; set; }

        /// <summary>
        /// Item SubType Name
        /// </summary>
        public string? ItemSubTypeName { get; set; }

    }
}
