using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class ErpDbContext : DbContext
    {
        List<string> VTVals = new List<string>() { "LAPTOP-K6ASI2P2", "sa", "123456", "AAA" };
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(
            "Data Source=LAPTOP-K6ASI2P2;Initial Catalog=AAA;User Id=sa;Password=123456"
        );

            //connectionstrings.com
        }
    }
  }
