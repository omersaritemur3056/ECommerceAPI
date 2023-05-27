using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Abstraction.Services
{
    public interface IProductService
    {
        Task<byte[]> QRCodeToProductAsync(string productId);
        Task StockUpdateToProductAsync(string productId, int stock);
    }
}
