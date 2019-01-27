using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopReturns
    {
        [Key]
        [Required]
        public int ReturnID { get; set; }
        [StringLength(8)]
        public string ShopRef { get; set; }
        [StringLength(8)]
        public string WarehouseRef { get; set; }
        public string Reference { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TransactionDate { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }
        public int QtyReturned { get; set; }
        [StringLength(16)]
        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
