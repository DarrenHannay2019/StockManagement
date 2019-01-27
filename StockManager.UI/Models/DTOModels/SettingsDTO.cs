using System.ComponentModel;

namespace StockManager.UI.Models.DTOModels
{
    public class SettingsDTO
    {
        public int CompanyID { get; set; }
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }  
        public string Address1 { get; set; }  
        public string Address2 { get; set; }       
        public string Address3 { get; set; }  
        public string Address4 { get; set; }
        [DisplayName("Post Code")]
        public string PostCode { get; set; }     
        public string Telephone { get; set; }
        [DisplayName("VAT Registration")]
        public string VATReg { get; set; }      
        public string Email { get; set; }
        public string Season { get; set; }
        [DisplayName("Website")]
        public string WWW { get; set; }
        [DisplayName("VAT Rate")]
        public decimal VatRate { get; set; }
    }
}
