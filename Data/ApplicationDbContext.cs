using CadastroDeEmrpesas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeEmrpesas.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Emrpesa> Emrpesas { get; set; }
    }
}
