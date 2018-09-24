using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementSystem.Model;

namespace TaskManagementApplication.Models
{
    public class Task
    {
        public Task(MainTask taskVM)
        {
            Title = taskVM.Title;
            Description = taskVM.Description;
            Assignee = taskVM.Assignee;
            Reporter = taskVM.Reporter;
            Comments = taskVM.Comments;
            Duration = taskVM.Duration;
         }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Assignee { get; set; }
        public string Reporter { get; set; }
        public string Comments { get; set; }
        public int Duration { get; set; }

    }
}