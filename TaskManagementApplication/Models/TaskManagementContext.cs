using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Model
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext()
        {
        }

        public TaskManagementContext(DbContextOptions<TaskManagementContext> options) : base(options)
        {
            
        }

        public DbSet<MainTask> MainTasks { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Board> Boards { get; set; }
    }
}
