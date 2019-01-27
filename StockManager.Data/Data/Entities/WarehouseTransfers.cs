using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class WarehouseTransfers
    {
        [Key]       
        public int WarehouseTransferID { get; set; }
        public string Reference { get; set; }
        [DataType(DataType.Date)]       
        public DateTime TransferDate { get; set; }
        [StringLength(8)]
        public string FromWarehouseRef { get; set; }   
        [StringLength(8)]
        public string ToWarehouseRef { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }
        public int TotalGarmentsQtyOut { get; set; }      
        public int TotalBoxesQtyOut { get; set; }      
        public int TotalUnitsQtyOut { get; set; }       
        [StringLength(16)]
        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]        
        public DateTime CreatedDate { get; set; }
    }
}
