using Microsoft.EntityFrameworkCore;

namespace Contact_US.Models;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<contactUsEntity> ContactUS { get; set; }
    
}