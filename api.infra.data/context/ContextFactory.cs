using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // Usado para criar as Migrações
            var connectionString = "Server=localhost;Port=5432;Database=dbAPIEstudos;UID=postgres;Pwd=postgres";
            var optionsBuilder   = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new MyContext(optionsBuilder.Options) ;
        }
    }
}