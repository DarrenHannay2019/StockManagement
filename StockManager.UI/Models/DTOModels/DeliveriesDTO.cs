using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.UI.Models.DTOModels
{
    public class DeliveriesDTO
    {   
        [DisplayName("Delivery ID")]
        public int DeliveryID { get; set; }
        [DisplayName("Our Ref")]
        public string OurRef { get; set; }
        [DisplayName("Supplier")]
        public string SupplierRef { get; set; }
        [DisplayName("Warehouse")]
        public string WarehouseRef { get; set; }
        public string Season { get; set; }
        [DisplayName("Total Garments")]
        public int TotalGarments { get; set; }
        [DisplayName("Total Hangers")]
        public int TotalHangers { get; set; }
        [DisplayName("Total Boxes")]
        public int TotalBoxes { get; set; }
        [DisplayName("Net Amount")]
        public double NetAmount { get; set; }
        [DisplayName("Delivery Charge")]
        public double DeliveryCharge { get; set; }
        public double Commission { get; set; }
        [DisplayName("Vat Amount")]
        public double VATAmount { get; set; }
        [DisplayName("Total Amount")]
        public double GrossAmount { get; set; }
        [DisplayName("Delivery Date")]
        public DateTime DeliveryDate { get; set; }
        public string Notes { get; set; }
        public string Invoice { get; set; }      
        public string Shipper { get; set; }
        [DisplayName("Shipper Invoice")]
        public string ShipperInvoice { get; set; }     
        public string CreatedBy { get; set; }       
        public DateTime CreatedDate { get; set; }
    }
}
