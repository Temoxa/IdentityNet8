using Microsoft.EntityFrameworkCore;

namespace TestIndetity8.Data;

public class Init(ApplicationDbContext context)
{
    public async Task MigrationAsync()
        => await context.Database.MigrateAsync();
}