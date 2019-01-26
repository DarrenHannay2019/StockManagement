using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class DelliveryLines
    {
        [Key]
        public int DeliveryLinesID { get; set; }
        public int DeliveryID { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }
        public int QtyHangers { get; set; }
        public int QtyBoxes { get; set; }
        public int QtyGarments { get; set; }
        [DataType(DataType.Currency)]
        public double NetAmount { get; set; }
    }
}
