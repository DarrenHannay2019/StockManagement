using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockManager.UI.Models.DTOModels;

namespace StockManager.UI.Models.FunctionViewModels
{
    public class PurchaseOrderView
    {
        public List<List<DeliveriesDTO>> PurchaseOrders { get; set; }
    }
}
