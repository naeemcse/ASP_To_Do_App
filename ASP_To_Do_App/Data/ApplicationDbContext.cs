using Microsoft.EntityFrameworkCore;

namespace ASP_To_Do_App.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {

            
        }
        public DbSet<Models.ToDoList> ToDoLists { get; set; }

    }
}
