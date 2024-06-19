using FBtarjeta.Models;
using Microsoft.EntityFrameworkCore;

namespace FBtarjeta
{
    public class AplicationDBContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options) 
        {

        }
    }
}
