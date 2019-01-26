using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class shopDeliveries
    {
        [Key]
        public int ShopDeliveryID { get; set; }

        [Required]
        [StringLength(8)]
        public string ShopRef { get; set; }

        //[ForeignKey("WarehouseRef")]
        [Required]
        [StringLength(8)]
        public string WarehouseRef { get; set; }

        [StringLength(50)]
        public string DeliveryRef { get; set; }

        [Required]
        public int TotHangers { get; set; }

        [Required]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DeliveryDate { get; set; }

        public string Notes { get; set; }

        [Required]
        [StringLength(16)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
