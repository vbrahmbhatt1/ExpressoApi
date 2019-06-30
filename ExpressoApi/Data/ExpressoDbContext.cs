using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpressoApi.Models;

namespace ExpressoApi.Data
{
    public class ExpressoDbContext:DbContext
    {
        public ExpressoDbContext(DbContextOptions<ExpressoDbContext>options): base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


    }
}
