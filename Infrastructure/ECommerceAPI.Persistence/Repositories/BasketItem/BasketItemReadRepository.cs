﻿using ECommerceAPI.Application.Repositories.BasketItem;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.BasketItem
{
    public class BasketItemReadRepository : ReadRepository<Domain.Entities.BasketItem>, IBasketItemReadRepository
    {
        public BasketItemReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
