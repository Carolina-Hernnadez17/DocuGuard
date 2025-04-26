using Microsoft.EntityFrameworkCore;

namespace DocuGuard.Models
{
    public class DocuGuardContext : DbContext
    {
        public DocuGuardContext(DbContextOptions<DocuGuardContext> options) : base(options) { }

        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<documentos> documentos { get; set; }
        public DbSet<permisos> permisos { get; set; }   
    }
}
