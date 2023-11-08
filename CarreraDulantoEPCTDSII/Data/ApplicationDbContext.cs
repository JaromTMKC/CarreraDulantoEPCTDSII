using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarreraDulantoEPCTDSII.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() 
        { 
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarreraDulantoEPCTDSII.Models.Entidades.ValesDetCarrera>
            ValesDet
        {  get; set; }

        public virtual DbSet<CarreraDulantoEPCTDSII.Models.Entidades.ArticuloCarrera>
            Articulo
        {  get; set; }

        public virtual DbSet<CarreraDulantoEPCTDSII.Models.Entidades.ValesCabCarrera>
            ValesCab
        {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JAROMTMKA;" +
                "Database=DBVales2023DSI;" +
                "User id=sa;" +
                "Password=1234;" +
                "MultipleActiveResultSets=true;");
        }
    }
}