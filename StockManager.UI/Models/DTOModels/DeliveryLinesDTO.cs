using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class DeliveryLinesDTO
    {
        public int DeliveryLinesID { get; set; }
        public int DeliveryID { get; set; }
        [DisplayName("Stock Code")]
        public string StockCode { get; set; }
        [DisplayName("Hangers")]
        public int QtyHangers { get; set; }
        [DisplayName("Boxes")]
        public int QtyBoxes { get; set; }
        [DisplayName("Garments")]
        public int QtyGarments { get; set; }
        [DisplayName("Amount")]
        public double NetAmount { get; set; }
    }
}
