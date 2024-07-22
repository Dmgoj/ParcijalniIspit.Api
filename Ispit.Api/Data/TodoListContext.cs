using Ispit.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Ispit.Api.Data
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options) { }
        public virtual DbSet<TodoList> TodoLists { get; set; }

       
    }
}
