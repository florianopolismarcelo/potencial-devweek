using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;

public class DatabaseContext : DbContext
{
    public DatabaseContex(DbContextOptions<DatabaseContext> options)
    {
        
    }
    public int DbSet<Pessoa> Pessoas { get; set; }

    public int DbSet<Contrato> Contratos { get; set; }
}