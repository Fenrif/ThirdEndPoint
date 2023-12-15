using Microsoft.EntityFrameworkCore;
using ThirdEndPoint.Models;

namespace ThirdEndPoint.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<UserRegisterInfo> UserThirdEndPoint { get; set; }
    }
}
