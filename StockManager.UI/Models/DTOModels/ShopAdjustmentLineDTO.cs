using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class ShopAdjustmentLineDTO
    {
        [DisplayName("Shop Adjustment Line ID")]
        public int ShopAdjustmentLineID { get; set; }
        [DisplayName("Shop Adjustment ID")]
        public int ShopAdjustmentsID { get; set; }
        [DisplayName("Stock Code")]
        public string StockCode { get; set; }
        [DisplayName("Movement Type")]
        public string MovementType { get; set; }
        [DisplayName("Quantity")]
        public int Qty { get; set; }
        public decimal Values { get; set; }
    }
}
