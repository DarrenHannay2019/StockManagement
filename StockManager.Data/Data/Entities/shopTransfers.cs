using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopTransfers
    {
        [Key]
        [Required]
        public int ShopTransferID { get; set; }
        public string Reference { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TransferDate { get; set; }
        public string FromShopRef { get; set; }
        public string ToShopRef { get; set; }
        public int TotalQtyOut { get; set; }
        public int TotalQtyIn { get; set; }
        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
