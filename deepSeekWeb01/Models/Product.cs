using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace deepSeekWeb01.Models
{
    public class Product
    {
        public int Id { get; set; } //Primary key


        [Required(ErrorMessage = "Name is required")] //validation
        public string Name { get; set; }


        [Range(1,100,ErrorMessage ="Price must be $1-$100")]
        public decimal price {  get; set; }
     }
}