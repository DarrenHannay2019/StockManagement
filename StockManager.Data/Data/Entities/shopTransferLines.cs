using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopTransferLines
    {
        [Key]
        [Required]
        public int TransferLineID { get; set; }
        public int TransferID { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }
        public int CurrentQty { get; set; }
        public int TOQty { get; set; }
        public int TIQty { get; set; }
    }
}
