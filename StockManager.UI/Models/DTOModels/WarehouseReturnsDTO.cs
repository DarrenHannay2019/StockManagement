using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.UI.Models.DTOModels
{
    public class WarehouseReturnsDTO
    {
        public int WarehouseReturnID { get; set; }
        public string Reference { get; set; }
      
        public DateTime ReturnDate { get; set; }
    
        public string FromWarehouseRef { get; set; }
      
        public string ToWarehouseRef { get; set; }
        public int TotalGarmentsQty { get; set; }
        public int TotalBoxesQty { get; set; }
        public int TotalUnitsQty { get; set; }
        public int CreatedBy { get; set; }
       
        public DateTime CreatedDate { get; set; }
    }
}
