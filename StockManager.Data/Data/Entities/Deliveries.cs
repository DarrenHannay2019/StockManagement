using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StockManager.Data.Data.Entities
{
    public class Deliveries
    {
        [Key]
        public int DeliveryID { get; set; }
        [StringLength(30)]
        public string StockCode { get; set; }
        [StringLength(8)]
        public string SupplierRef { get; set; }
        [StringLength(8)]
        public string WarehouseRef { get; set; }
        [StringLength(50)]
        public string Season { get; set; }       
        public int TotalGarments { get; set; }       
        public int TotalHangers { get; set; }      
        public int TotalBoxes { get; set; }
        [DataType(DataType.Currency)]
        public double NetAmount { get; set; }
        [DataType(DataType.Currency)]
        public double DeliveryCharge { get; set; }
        [DataType(DataType.Currency)]
        public double Commission { get; set; }
        [DataType(DataType.Currency)]
        public double VATAmount { get; set; }
        [DataType(DataType.Currency)]
        public double GrossAmount { get; set; }
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public string Notes { get; set; }
        public string Invoice { get; set; }
        [StringLength(50)]
        public string Shipper { get; set; }
        public string ShipperInvoice { get; set; }
        [StringLength(16)]
        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
       
    }
}
