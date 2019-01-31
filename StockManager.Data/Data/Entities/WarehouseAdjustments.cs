using System;
using System.Collections.Generic;
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
        [StringLength(30)]
        public string StockCode { get; set; }
        [StringLength(50)]
        public string MovementType { get; set; }
        public int TotalItems { get; set; }
        [DataType(DataType.Date)]      
        public DateTime MovementDate { get; set; }       
        [StringLength(16)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Warehouse> Warehouses { get; set; }
        public List<Stock> Stock { get; set; }
    }
}
