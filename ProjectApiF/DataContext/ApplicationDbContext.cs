using Microsoft.EntityFrameworkCore;
using ProjectApiF.Models;

namespace ProjectApiF.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<FuncionarioModels> Funcionarios { get; set; }
    }
}
