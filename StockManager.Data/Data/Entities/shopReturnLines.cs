using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopReturnLines
    {
        [Key]
        [Required]
        public int ReturnLineID { get; set; }
        public int ReturnID { get; set; }
        public string StockCode { get; set; }
        public int Qty { get; set; }
        public double Value { get; set; }
    }
}
