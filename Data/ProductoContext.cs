using Microsoft.EntityFrameworkCore;
using Pc03Progra1.Models;

namespace Pc03Progra1.Data
{
    public class ProductoContext : DbContext
    {   
        public DbSet<Producto> Productos { get; set;}

        public ProductoContext(DbContextOptions dco) : base(dco){

        }
    }
}