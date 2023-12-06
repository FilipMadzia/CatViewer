using CatViewer.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CatViewer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<CatEntity> CatEntities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
