using EFChallenge.Data.Models.Item;
using EFChallenge.DTOs.ItemDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Services.Interfaces
{
    public interface IItemService
    {
        public ItemDto AddItem(ItemDto itemDto);
        public ItemDto UpdateItem(ItemDto itemDto);
        public Item UpdateItem(int id, Item item);
        public Item DeleteItem(Guid id);
        public IList<Item> GetItems();
    }
}
