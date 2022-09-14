using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.Data
{
    public class TodoAPIContext : DbContext
    {
        public TodoAPIContext (DbContextOptions<TodoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<TodoAPI.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
