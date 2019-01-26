using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopAdjustments
    {
        [Key]
        public int ShopAdjustID { get; set; }
        StringLength(8)]
        public string ShopRef { get; set; }
        public string Reference { get; set; }
        public int TotalLossItems { get; set; }
        public int TotalGainItems { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime MovementDate { get; set; }
        [StringLength(16)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
