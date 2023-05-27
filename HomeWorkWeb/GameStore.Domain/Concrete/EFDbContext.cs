using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Concrete
{
  public class EFDbContext : DbContext
  {
    //public EFDbContext(string connectionString) : base(nameOrConnectionString: connectionString)
    public EFDbContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

    public DbSet<Game> Games { get; set; }

  }
}
