using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class ShopReturnLinesDTO
    {
        [DisplayName("Return Line ID")]
        public int ReturnLineID { get; set; }
        [DisplayName("Return ID")]
        public int ReturnID { get; set; }
        [DisplayName("Stock Code")]
        public string StockCode { get; set; }
        [DisplayName("Quantity")]
        public int Qty { get; set; }
        public double Value { get; set; }
    }
}
