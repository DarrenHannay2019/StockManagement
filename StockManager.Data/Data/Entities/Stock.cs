using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class Stock
    {
        [Key]
        [StringLength(30)]
        public string StockCode { get; set; }

        [StringLength(8)]
        public string SupplierRef { get; set; }

        [StringLength(60)]
        public string Season { get; set; }

        public bool DeadCode { get; set; }

        [DataType(DataType.Currency]
        public double AmtTakes {get; set; }

        public int DeliveredQtyHangers { get; set; }
        [DataType(DataType.Currency]
        public double CostVal { get; set; }

        public bool ZeroQty { get; set; }

        [StringLength(16)]
        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime]
        public DateTime CreatedDate { get; set; }
    }
}
