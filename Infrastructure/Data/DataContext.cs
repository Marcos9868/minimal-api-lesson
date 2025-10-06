using Microsoft.EntityFrameworkCore;

namespace minimal_api.Infrastructure.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
       {} 

    }
}