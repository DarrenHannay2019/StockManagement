using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class WarehouseAdjustments
    {
        [Key]
        public int WarehouseAdjustID { get; set; }
        [StringLength(8)]
        public string WarehouseRef { get; set; }
        public string Reference { get; set; }
        public int TotalLossItems { get; set; }
        public int TotalGainItems { get; set; }
        [DataType(DataType.Date)]      
        public DateTime MovementDate { get; set; }
        [StringLength(16)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
