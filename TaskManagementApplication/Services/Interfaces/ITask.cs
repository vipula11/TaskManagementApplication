using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Model;

namespace TaskManagementApplication.Services.Interfaces
{
    public interface  ITask
    {
        IEnumerable<MainTask> GetAll();
        void Insert(MainTask mainTask);
    }
}
