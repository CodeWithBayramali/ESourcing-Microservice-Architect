using MediatR;
using Ordering.Application.Responses;
using System.Collections.Generic;

namespace Ordering.Application.Queries
{
    public class GetOrdersBySellerUserNameQuery : IRequest<IEnumerable<OrderResponse>>
    {
        public string UserName { get; set; }

        public GetOrdersBySellerUserNameQuery(string userName)
        {
            UserName = userName;
        }
    }
}
