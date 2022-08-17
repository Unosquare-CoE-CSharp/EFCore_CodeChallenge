using EFChallenge.Data;
using EFChallenge.Data.Models.Item;
using EFChallenge.DTOs.ItemDTOs;
using EFChallenge.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;

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

        public IEnumerable<ItemReportDTO> GetItemReport()
        {
            var result =  _context.Items
                .Include(t => t.ItemType)
                .Include(t => t.ParentItem)
                    .ThenInclude(t => t.ItemType)
                .Include(t => t.ItemStatus)
                .Include(t => t.ItemIdentifier) 
                    .ThenInclude(t => t.identifier)
                .Include(t => t.ItemSubType)
                .Select( x => new ItemReportDTO() {
                    Id = x.Id,
                    TypeName = x.ItemType.Name,
                    ParentId = (Guid)x.ParentItemId,
                    ParentType = x.ParentItem.ItemType.Name,
                    StatusName = x.ItemStatus.Name,
                    IdentifierID = x.ItemIdentifier.ItemIdentifierId,
                    IdentifierTypeName = x.ItemIdentifier.identifier.IdentifierType.Name,
                    Data = x.ItemIdentifier.identifier.Data,
                    ItemSubTypeName = x.ItemSubType.Name
                }).ToList();
            return result;
        }
    }
}

