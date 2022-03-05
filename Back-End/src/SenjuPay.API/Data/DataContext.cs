using Microsoft.EntityFrameworkCore;
using SenjuPay.API.Model;

namespace SenjuPay.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }
        public DbSet<Empresa> Empresas { get; set; }
    }
}