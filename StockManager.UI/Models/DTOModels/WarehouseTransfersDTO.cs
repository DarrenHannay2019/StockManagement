using System.ComponentModel;
using System;

namespace StockManager.UI.Models.DTOModels
{
    public class WarehouseTransfersDTO
    { 
        public int WarehouseTransferID { get; set; }
        public string Reference { get; set; }
        [DisplayName("Movement Date")]
        public DateTime TransferDate { get; set; }
        [DisplayName("From Warehouse")]
        public string FromWarehouseRef { get; set; }
        [DisplayName("To Warehouse")]
        public string ToWarehouseRef { get; set; }
        [DisplayName("Garments Out")]
        public int TotalGarmentsQtyOut { get; set; }
        [DisplayName("Garments In")]
        public int TotalGarmentsQtyIn { get; set; }
        [DisplayName("Boxes Out")]
        public int TotalBoxesQtyOut { get; set; }
        [DisplayName("Boxes In")]
        public int TotalBoxesQtyIn { get; set; }
        [DisplayName("Unit Out")]
        public int TotalUnitsQtyOut { get; set; }
        public int TotalUnitsQtyIn { get; set; }
       
        public string CreatedBy { get; set; }
      
        public DateTime CreatedDate { get; set; }
    }
}
