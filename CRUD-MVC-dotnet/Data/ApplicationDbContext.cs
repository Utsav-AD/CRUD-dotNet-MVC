using CRUD_MVC_dotnet.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC_dotnet.Data
{
    public class ApplicationDbContext : DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { 

        }

        public DbSet<Student> Students {  get; set; }


    }
}
