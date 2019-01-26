using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class Settings
    {
        [Key]
        public int CompanyID { get; set; }
        [Required]
        [StringLength(50)]       
        public string CompanyName { get; set; }
        [StringLength(50)]        
        public string Address1 { get; set; }
        [StringLength(50)]       
        public string Address2 { get; set; }
        [StringLength(50)]       
        public string Address3 { get; set; }
        [StringLength(50)]       
        public string Address4 { get; set; }
        [StringLength(12)]       
        public string PostCode { get; set; }
        [StringLength(18)]       
        public string Telephone { get; set; }
        [StringLength(50)]      
        public string VATReg { get; set; }
        [StringLength(255)]
        public string Email { get; set; }      
        public string Season { get; set; }
        [StringLength(255)]      
        public string WWW { get; set; }        
        public decimal VatRate { get; set; }
    }
}
