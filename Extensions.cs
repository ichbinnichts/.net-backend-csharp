﻿using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    //Static class that will convert the item to itemDTO
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}
