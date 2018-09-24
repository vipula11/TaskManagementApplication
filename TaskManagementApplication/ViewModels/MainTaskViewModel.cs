using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Model;

namespace TaskManagementSystem.ViewModel
{
    public class MainTaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Assignee { get; set; }
        public string Reporter { get; set; }
        public string Comments { get; set; }
        public int Duration { get; set; }
        public List<string> StateType { get; set; }
        public List<string> TaskType { get; set; }

        public virtual MainTask MainTask { get; set; }
    }
}
