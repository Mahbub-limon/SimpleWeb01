using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace deepSeekWeb01.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }    //Products table

    }
}