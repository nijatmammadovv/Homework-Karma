using Homework_Karma_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Karma_.Data_Access_Layer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
             
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
