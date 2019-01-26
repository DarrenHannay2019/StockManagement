using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class WarehouseTransferLines
    {
        [Key]
        public int WarehouseTransferLineID { get; set; }
        public int WarehouseTransferID { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }        
        public int TOQtyGarments { get; set; }      
        public int TOQtyBoxes { get; set; }       
        public int TOQtyUnits { get; set; }      
    }
}
