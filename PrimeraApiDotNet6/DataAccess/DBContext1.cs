using Microsoft.EntityFrameworkCore;
using PrimeraApiDotNet6.Models.DataModels;

namespace PrimeraApiDotNet6.DataAccess
{
    public class DBContext1: DbContext
    {
        public DBContext1(DbContextOptions<DBContext1> options):base(options)
        {

        }
        public DbSet<User>? Users { get; set; }
        //TODO: Add DbSets
    }
}
