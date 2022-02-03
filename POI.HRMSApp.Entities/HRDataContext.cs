using Microsoft.EntityFrameworkCore;
using POI.HRMSApp.Entities.Configuration;
using POI.HRMSApp.Entities.Models;

namespace POI.HRMSApp.Entities;

public class HRMSDataContext : DbContext
{
  public HRMSDataContext(DbContextOptions options)
    : base(options)
  {
  }

  public DbSet<Department>? Departments { get; set; }
  public DbSet<Employee>? Employees { get; set; }
}