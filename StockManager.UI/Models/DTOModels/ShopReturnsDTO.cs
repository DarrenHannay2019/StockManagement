using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class ShopReturnsDTO
    {
        [DisplayName("Return ID")]
        public int ReturnID { get; set; }
        [DisplayName("Shop Reference")]
        public string ShopRef { get; set; }
        [DisplayName("Warehouse Reference")]
        public string WarehouseRef { get; set; }
        public string Reference { get; set; }
        [DisplayName("Transaction Date")]
        public DateTime TransactionDate { get; set; }
        [DisplayName("Quantity Returned")]
        public int QtyReturned { get; set; }
        [DisplayName("Created By")]
        public string CreatedBy { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
