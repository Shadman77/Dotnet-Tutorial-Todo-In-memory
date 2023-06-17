using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    // We are not importing TodoItem because it's in the same namespace?
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}