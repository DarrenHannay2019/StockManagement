using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopDeliveryLines
    {
        [Key]
        public int DeliveryLinesID { get; set; }

        //[ForeignKey("ShopDeliveryID")]
        [Required]
        public int ShopDeliveryID { get; set; }

        [Required]
        [StringLength(30)]
        public string StockCode { get; set; }

        [Required]
        public int QtyHangers { get; set; }
    }
}
