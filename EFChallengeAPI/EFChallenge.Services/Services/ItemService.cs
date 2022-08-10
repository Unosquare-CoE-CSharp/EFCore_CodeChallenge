using EFChallenge.Data;
using EFChallenge.Data.Models.Item;
using EFChallenge.DTOs.ItemDTOs;
using EFChallenge.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFChallenge.Services.Services
{
    public class ItemService : IItemService
    { 
        private readonly EFChallengeContext _context;

        public ItemService(EFChallengeContext context) => _context = context;

        public ItemDto AddItem(ItemDto itemDto)
        {
            var ItemToUpdate = new Item();
            ItemToUpdate.Id = itemDto.Id;
            ItemToUpdate.ItemTypeId = itemDto.ItemTypeId;
            ItemToUpdate.ItemStatusId = itemDto.ItemStatusId;
            ItemToUpdate.ItemSubTypeId = itemDto.ItemSubTypeId;
            ItemToUpdate.LocationId = itemDto.LocationId;
            ItemToUpdate.ParentItemId = itemDto.ParentItemId;

            _context.Items.Add(ItemToUpdate);
            _context.SaveChanges();
             return itemDto;
        }

        public Item DeleteItem(Guid id)
        {
              var itemToRemove = _context.Items.Find(id);
            if (itemToRemove != null)
            {
                _context.Items.Remove(itemToRemove);
                _context.SaveChanges();
                return itemToRemove;
            }
            return null;
        }
        public IList<Item> GetItems()
         {
                throw new NotImplementedException();
         }

        public ItemDto UpdateItem(ItemDto itemDto)
         {
            var exist = _context.Items.Where(x => x.Id == itemDto.Id).FirstOrDefault();
            if(exist != null)
            {
                exist.ItemTypeId = itemDto.ItemTypeId;
                exist.ItemStatusId = itemDto.ItemStatusId;
                exist.ItemSubTypeId = itemDto.ItemSubTypeId;
                exist.ParentItemId = itemDto.ParentItemId;
                _context.SaveChanges();
                return itemDto;
            }
            return null;
         }

        public Item UpdateItem(int id, Item item)
        {
            var exist = _context.Items.Where(x => x.Id == item.Id).FirstOrDefault();
            if (exist != null)
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
                return item;
            }
            return null;
        }

    }
}
