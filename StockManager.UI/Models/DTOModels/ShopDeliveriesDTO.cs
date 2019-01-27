using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class ShopDeliveriesDTO
    {
        [DisplayName("Shop Delivery ID")]
        public int ShopDeliveryID { get; set; }
        [DisplayName("Shop Reference")]
        public string ShopRef { get; set; }
        [DisplayName("Warehouse Reference")]
        public string WarehouseRef { get; set; }
        [DisplayName("Delivery Reference")]
        public string DeliveryRef { get; set; }
        [DisplayName("Total Hangers")]
        public int TotHangers { get; set; }
        [DisplayName("Delivery Date")]
        public DateTime DeliveryDate { get; set; }
        public string Notes { get; set; }
        [DisplayName("Created By")]
        public string CreatedBy { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
