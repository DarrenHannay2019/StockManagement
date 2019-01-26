using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
  

    public class Warehouse
    {
        public enum WHType
        {
            Active,
            Waste,
            Long
        }
        [Key]
        [StringLength(8)]
        public string WarehouseRef { get; set; }

        [StringLength(60)]
        public string WarehouseName { get; set; }

        [StringLength(60)]
        public string Address1 { get; set; }

        [StringLength(60)]
        public string Address2 { get; set; }

        [StringLength(60)]
        public string Address3 { get; set; }

        [StringLength(60)]
        public string Address4 { get; set; }

        [StringLength(60)]
        public string PostCode { get; set; }

        [StringLength(60)]
        public string ContactName { get; set; }

        [StringLength(60)]
        public string Telephone { get; set; }

        [StringLength(60)]
        public string Telephone2 { get; set; }

        [StringLength(60)]
        public string Fax { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        public string Memo { get; set; }

        public WHType? WarehouseType { get; set; }

        public bool Default { get; set; }

        [StringLength(16)]
        public string CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }


    }
}
