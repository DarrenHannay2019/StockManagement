using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class WarehouseReturnLines
    {
        [Key]   
        public int WarehouseReturnLineID { get; set; }
        public int ReturnID { get; set; }
        [StringLength(8)]
        public string StockCode { get; set; }
        public int CurrentQtyGarments { get; set; }
        public int CurrentQtyBoxes { get; set; }
        public int CurrentQtyUnits { get; set; }
        public int ReturnQtyGarments { get; set; }
        public int ReturnQtyBoxes { get; set; }
        public int ReturnQtyUnits { get; set; }
    }
}
