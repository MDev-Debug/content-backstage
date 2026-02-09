using Microsoft.EntityFrameworkCore;

namespace {{ parameters.projectName }}.Data
{
    public class {{ parameters.dbContextName }} : DbContext
    {
        public {{ parameters.dbContextName }}(DbContextOptions<{{ parameters.dbContextName }}> options)
            : base(options)
        {
        }

        // Adicione seus DbSets aqui
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
