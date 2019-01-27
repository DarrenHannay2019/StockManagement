using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockManager.Data.Data.Entities;

namespace StockManager.Data.Repositories
{
    public interface IReadRepository
    {
        IEnumerable<Deliveries> GetDeliveries(string id);
        Deliveries GetDeliveries();
    }
}
