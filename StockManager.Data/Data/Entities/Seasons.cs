using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Data.Data.Entities
{
    public class Seasons
    {
        [Key]
        public int SeasonID { get; set; }
        [StringLength(60)]
        public string SeasonName { get; set; }
    }
}
