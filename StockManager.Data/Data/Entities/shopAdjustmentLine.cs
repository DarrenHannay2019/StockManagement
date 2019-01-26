using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopAdjustmentLine
    {
        [Key]
        public int ShopAdjustmentLineID { get; set; }
        public int ShopAdjustmentsID { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }
        [StringLength(50)]
        public string MovementType { get; set; }
        public int Qty { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Values { get; set; }
    }
}
