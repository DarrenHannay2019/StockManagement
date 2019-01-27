using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class ShopTransferLinesDTO
    {
        [DisplayName("Transfer Line ID")]
        public int TransferLineID { get; set; }
        [DisplayName("Transfer ID")]
        public int TransferID { get; set; }
        [DisplayName("Stock Code")]
        public string StockCode { get; set; }
        [DisplayName("Current Quantity")]
        public int CurrentQty { get; set; }
        [DisplayName("Transfer Out Quantity")]
        public int TOQty { get; set; }
        [DisplayName("Transfer In Quantity")]
        public int TIQty { get; set; }
    }
}
