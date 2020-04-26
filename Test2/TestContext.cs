using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    public class TestContext : DbContext
    {
        public DbSet<Product> Table_1 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-S2L9C420;Database=Test_Table1;Integrated Security=True;");
        }
    }
   
    
}
