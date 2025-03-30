using Microsoft.EntityFrameworkCore;
namespace PostgreEFWebApi.Data
{
    public class WebApiDbContext:DbContext
    {
        private readonly IConfiguration configuration;

        public WebApiDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }



        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("EFDemo"));
        }
        public DbSet<PostgreEFWebApi.Entities.Person> Persons { get; set; }
        public DbSet<PostgreEFWebApi.Entities.Address> Addresses { get; set; }

    }
}
