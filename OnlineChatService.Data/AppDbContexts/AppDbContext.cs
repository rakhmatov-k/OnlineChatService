using Microsoft.EntityFrameworkCore;
using OnlineChatService.Domain.Configurations;
using OnlineChatService.Domain.Entities;

namespace OnlineChatService.Data.AppDbContexts;

public class AppDbContext : DbContext
{
    public DbSet<User> users {  get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Constants.ConnectionString);
    }
}
