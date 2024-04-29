using Crud.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class Applicationdbcontext: DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> Options) : base(Options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
