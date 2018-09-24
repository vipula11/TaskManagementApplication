using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementApplication.Services.Interfaces;
using TaskManagementSystem.Model;

namespace TaskManagementApplication.Services.Repo
{
    public class TaskRepo : ITask
    {

        private readonly TaskManagementContext _db;

        public TaskRepo()
        {
            _db = new TaskManagementContext();
        }

        public TaskRepo(TaskManagementContext db)
        {
            _db = db;
        }
        public IEnumerable<MainTask> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(MainTask mainTask)
        {
            _db.MainTasks.Add(mainTask);
        }
    }
}