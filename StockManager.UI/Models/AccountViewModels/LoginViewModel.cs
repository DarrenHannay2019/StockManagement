using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using StockManager.Data.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace StockManager.UI.Models.AccountViewModels
{
    public class LoginViewModel
    {
      
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string UserName { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
