using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;


namespace StockManager.UI.Models.DTOModels
{
    public class ShopAdjustmentsDTO
    {
        [DisplayName("Shop Adjustment ID")]
        public int ShopAdjustID { get; set; }
        [DisplayName("Shop Reference")]
        public string ShopRef { get; set; }
        public string Reference { get; set; }
        [DisplayName("Total Loss Items")]
        public int TotalLossItems { get; set; }
        [DisplayName("Total Gain Items")]
        public int TotalGainItems { get; set; }
        [DisplayName("Movement Date")]
        public DateTime MovementDate { get; set; }
        [DisplayName("Created By")]
        public string CreatedBy { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
