using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;

public class DatabaseContext : DbContext
{
    public DatabaseContex
    (
        DbContextOptions<DatabaseContext> options
        ) : base(options)
    {

    }
    public DbSet<Pessoa> Pessoas { get; set; }

    public DbSet<Contrato> Contratos { get; set; }

    protected override void OnModelCreating(ModelBuilder 
    builder)
    {
        builder.Entity<Pessoa>(tabela =>
        {
            tabela.HasKey( e => e.Id);

        });
        builder.Entity<Contrato>(e =>
        {

        });
    }

}
