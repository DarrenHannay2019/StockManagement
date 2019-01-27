using System;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class WarehouseAdjustmentsDTO
    {
        public int WarehouseAdjustID { get; set; }
        [DisplayName("Warehouse")]
        public string WarehouseRef { get; set; }
        public string Reference { get; set; }
        [DisplayName("Total Loss Items")]
        public int TotalLossItems { get; set; }
        [DisplayName("Total  Gain Items")]
        public int TotalGainItems { get; set; }
        [DisplayName("Movement Date")]
        public DateTime MovementDate { get; set; }
        [DisplayName("Created By")]
        public string CreatedBy { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
