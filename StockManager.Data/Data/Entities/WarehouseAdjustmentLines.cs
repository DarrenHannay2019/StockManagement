using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class WarehouseAdjustmentLines
    {
        [Key]
        public int WarehouseAdjustmentLineID { get; set; }
        public int WarehouseAdjustmentsID { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }
        [StringLength(50)]
        public string MovementType { get; set; }
        public int Qty { get; set; }
        [DataType(DataType.Currency)]
        public double Values { get; set; }
    }
}
