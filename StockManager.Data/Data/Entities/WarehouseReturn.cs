using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class WarehouseReturn
    {
        [Key]        
        public int WarehouseReturnID { get; set; }
        public string Reference { get; set; }
        [DataType(DataType.Date)]        
        public DateTime ReturnDate { get; set; }
        [StringLength(8)]
        public string FromWarehouseRef { get; set; }
        [StringLength(8)]
        public string ToWarehouseRef { get; set; }
        [StringLength(8)]
        public string StockCode { get; set; }
        public int TotalGarmentsQty { get; set; }
        public int TotalBoxesQty { get; set; }
        public int TotalUnitsQty { get; set; }
        public int CreatedBy { get; set; }
        [DataType(DataType.DateTime)]       
        public DateTime CreatedDate { get; set; }
    }
}
