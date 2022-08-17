//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

using EFChallenge.Data.Models.Item;
using EFChallenge.DTOs.ItemDTOs;


namespace EFChallenge.Services.Interfaces
{
    /// <summary>
    /// Interface IItemService
    /// </summary>
    public interface IItemService
    {
        /// <summary>
        /// Method to create a Item 
        /// </summary>
        /// <param name="itemDto">Type Item</param>
        /// <returns>Item type model</returns>
        public ItemDto AddItem(ItemDto itemDto);

        /// <summary>
        /// Method to update a Item 
        /// </summary>
        /// <param name="itemDto">Type Item</param>
        /// <returns>Item tye model</returns>
        public ItemDto UpdateItem(ItemDto itemDto);

        /// <summary>
        /// Method to update a item
        /// </summary>
        /// <param name="id">id item</param>
        /// <param name="item">object item</param>
        /// <returns>Item Object</returns>
        public Item UpdateItem(int id, Item item);

        /// <summary>
        /// Method to delete a item
        /// </summary>
        /// <param name="id">Id item</param>
        /// <returns></returns>
        public Item DeleteItem(Guid id);

        /// <summary>
        /// Method to get a itemReportDto
        /// </summary>
        /// <returns>ItemReportDto</returns>
        public IEnumerable<ItemReportDTO> GetItemReport();
    }
}
