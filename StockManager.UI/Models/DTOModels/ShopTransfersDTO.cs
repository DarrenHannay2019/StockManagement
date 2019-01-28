using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class ShopTransfersDTO
    {
        [DisplayName("Shop Transfer ID")]
        public int ShopTransferID { get; set; }
        public string Reference { get; set; }
        [DisplayName("Transfer Date")]
        public DateTime TransferDate { get; set; }
        [DisplayName("From Shop Reference")]
        public string FromShopRef { get; set; }
        [DisplayName("To Shop Reference")]
        public string ToShopRef { get; set; }
        [DisplayName("Total Quantity Out")]
        public int TotalQtyOut { get; set; }
        [DisplayName("Total Quantity In")]
        public int TotalQtyIn { get; set; }
        [DisplayName("Created By")]
        public string CreatedBy { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}


