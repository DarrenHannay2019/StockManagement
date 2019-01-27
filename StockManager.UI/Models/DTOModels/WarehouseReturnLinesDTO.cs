using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.UI.Models.DTOModels
{
    public class WarehouseReturnLinesDTO
    {
        public int WarehouseReturnLineID { get; set; }
        public int ReturnID { get; set; }
      
        public string StockCode { get; set; }
        public int CurrentQtyGarments { get; set; }
        public int CurrentQtyBoxes { get; set; }
        public int CurrentQtyUnits { get; set; }
        public int ReturnQtyGarments { get; set; }
        public int ReturnQtyBoxes { get; set; }
        public int ReturnQtyUnits { get; set; }
    }
}
