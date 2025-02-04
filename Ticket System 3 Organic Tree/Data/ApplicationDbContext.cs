using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ticket_System_3_Organic_Tree.Models;

namespace Ticket_System_3_Organic_Tree.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ticket_System_3_Organic_Tree.Models.Ticket> Ticket { get; set; } = default!;
        public DbSet<Ticket_System_3_Organic_Tree.Models.Knowledge> Knowledge { get; set; } = default!;
    }
}
