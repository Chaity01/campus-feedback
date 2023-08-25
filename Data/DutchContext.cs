using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DutchTreat.Data
{
  public class DutchContext : IdentityDbContext<StoreUser>
  {

    private readonly IConfiguration _config;

    public DutchContext(IConfiguration config ) 
    {
      _config = config;
    }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Student> Students { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder bldr)
    {
      base.OnConfiguring(bldr);

      bldr.UseSqlServer(_config.GetConnectionString("DutchConnectionString"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}
