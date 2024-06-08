using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace API
{
    /// <summary>
    /// 
    /// </summary>
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions  Options ) : base(Options)
        {
            
        }

       public DbSet<AppUser> Users { get; set; }
        
    }
}
