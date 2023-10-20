using Microsoft.EntityFrameworkCore;
using PenggunaSampah.Models;


namespace PenggunaSampah.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PenggunaModel> Pengguna { get; set; }
    }
}
