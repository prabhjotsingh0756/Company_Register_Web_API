using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Company_Register_Web_API.Model;

namespace Company_Register_Web_API.Models
{
    public class Company_Register_DataContext : DbContext
    {
        public Company_Register_DataContext (DbContextOptions<Company_Register_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Company_Register_Web_API.Model.Company> Company { get; set; }
    }
}
