using infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Contexts;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<SubscribersEntity> Subscribers { get; set; }
    public DbSet<CourseEntity> Courses { get; set; }
}
