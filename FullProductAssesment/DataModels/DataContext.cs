using Microsoft.EntityFrameworkCore;

namespace FullProductAssesment.DataModels
{
    public class DataContext : DbContext                        
    {
        public DataContext(DbContextOptions<DataContext> options) :base (options)
        { }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<SalesModel> Sales { get; set; }
        public DbSet<StoreModel> Stores { get; set; }

    }

    

}
