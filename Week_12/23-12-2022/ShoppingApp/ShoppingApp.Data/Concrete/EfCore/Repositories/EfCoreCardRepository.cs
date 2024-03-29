﻿using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCardRepository : EfCoreGenericRepository<Card>, ICardRepository
    {
        public EfCoreCardRepository(ShopAppContext context) : base(context) 
        {
        
        }
        private ShopAppContext ShopAppContext
        {
            get { return _context as ShopAppContext; }
        }

        public async Task AddToCard(string userId, int productId, int quantity)
        {
            var card = await GetCardByUserId(userId);
            if (card != null)
            {
                var index = card.CardItems.FindIndex(ci=>ci.ProductId==productId);
                if (index < 0)//Eğer ürün daa önceden sepete eklememişse
                {
                    card.CardItems.Add(new CardItem
                    {
                        ProductId = productId,
                        CardId = card.Id,
                        Quantity = quantity
                    });
                }
                else//Eğer ürn daha önceden sepete eklenmişse
                {
                    card.CardItems[index].Quantity += quantity;
                }
               
                ShopAppContext.Cards.Update(card);
                
            }
        }
        
        public async Task<Card> GetCardByUserId(string userId)
        {
            var card =  ShopAppContext
                .Cards
                .Include(c=>c.CardItems)
                .ThenInclude(ci=>ci.Product)
                .FirstOrDefault(c=>c.UserId== userId);
            return card;
        }
    }
}
