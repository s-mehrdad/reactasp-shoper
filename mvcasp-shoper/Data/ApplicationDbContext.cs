// ===========================================================================
/// <summary>
/// ApplicationDbContext.cs
/// project
/// created by Mehrdad Soleimanimajd on 02.08.2023
/// </summary>
/// <created>ʆϒʅ, 02.08.2023</created>
/// <changed>ʆϒʅ, 09.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using mvcasp_shoper.Models;

namespace mvcasp_shoper.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<TodoModel> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TodoModel>().ToTable("Todos");
        }


    }

    public class Initialize
    {
        public static void Initializer(ApplicationDbContext _context)
        {
            if (!_context.Todos.Any())
            {
                var todos = new TodoModel[]
                {
                    new TodoModel{Name="first to do", IsDone=true },
                    new TodoModel{Name="second to do" },
                    new TodoModel{Name="to do the number third" },
                    new TodoModel{Name="to do so force may be with you :/" },
                };
                _context.Todos.AddRange(todos);
                _context.SaveChanges();
            }
        }
    }
}