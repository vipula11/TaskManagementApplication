using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskManagementSystem.ViewModel;

namespace TaskManagementSystem.Model
{
    [Table ("MainTasks")]
    public class MainTask
    {

        public MainTask(MainTaskViewModel mainTaskVM)
        {
            TaskId = mainTaskVM.Id;
            Title = mainTaskVM.Title;
            Description = mainTaskVM.Description;
            Assignee = mainTaskVM.Assignee;
            Reporter = mainTaskVM.Reporter;
            Comments = mainTaskVM.Comments;
            Duration = mainTaskVM.Duration;
        }

        internal MainTask Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public MainTask()
        { }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Task Id")]
        [Key]
        public int TaskId { get; set; }

        [Required, Display(Name = "TaskType Id")]
        public int TaskTypeId { get; set; }

        [Required, Display(Name = "State Id")]
        public int StateId { get; set; }

        [Required, Display(Name = "Title"), StringLength(25)]
        public string Title { get; set; }

        [Required, Display(Name = "Description"), StringLength(100)]
        public string Description { get; set; }

        [Required, Display(Name = "Assignee"), StringLength(25)]
        public string Assignee { get; set; }

        [Required, Display(Name = "Reporter"), StringLength(25)]
        public string Reporter { get; set; }

        [Required, Display(Name = "Comments"), StringLength(100)]
        public string Comments { get; set; }

        [Required, Display(Name = "Duration")]
        public int Duration { get; set; }

        [Required, Display(Name = "RefTask Id")]
        [ForeignKey("ParentTaskGroup")]
        public int ReferenceTaskId { get; set; }

        public virtual MainTask ParentTaskGroup { get; set; }
        public virtual ICollection<MainTask> Children { get; set; }

        public virtual TaskType TaskType { get; set; }
        public virtual State State { get; set; }
    }
}
