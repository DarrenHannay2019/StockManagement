using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class shopDeliveryLinesDTO
    {
        [DisplayName("Delivery Lines ID")]
        public int DeliveryLinesID { get; set; }
        [DisplayName("Shop Delivery ID")]
        public int ShopDeliveryID { get; set; }
        [DisplayName("Stock Code")]
        public string StockCode { get; set; }
        [DisplayName("Qty Hangers")]
        public int QtyHangers { get; set; }
    }
}
