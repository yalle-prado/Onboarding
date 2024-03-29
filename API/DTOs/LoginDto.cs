using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using SQLitePCL;

namespace API.DTOs
{
    public class LoginDto
    { 
        [Required]
        public string Username {get; set;}
        [Required]        
        public string Password {get; set;}
    }
}