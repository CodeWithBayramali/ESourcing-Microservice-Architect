using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Entities;
using Ordering.Domain.Repositories;
using Ordering.Infrastructure.Data;
using Ordering.Infrastructure.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext dbContext): base(dbContext)
        {

        }
        public async Task<IEnumerable<Order>> GetOrderBySellerName(string userName)
        {
            var orderList = await _dbContext.Orders
                                            .Where(o => o.SellerUserName == userName)
                                            .ToListAsync();
            return orderList;
        }
    }
}
