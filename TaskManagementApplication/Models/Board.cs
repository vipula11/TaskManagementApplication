using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.ViewModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Model
{
    [Table("Board")]
    public class Board
    {
        public Board()
        {
            MainTasks = new HashSet<MainTask>();
        }

        public Board(BoardViewModel BoardVM)
        {
            TaskId = BoardVM.TaskId;
            Name = BoardVM.Name;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Board Id")]
        [Key]
        public int BoardId { get; set; }

        [Required, Display(Name = "Name"), StringLength(25)]
        public string Name { get; set; }

        [Required, Display(Name = "Task Id")]
        public int TaskId { get; set; }

        public virtual ICollection<MainTask> MainTasks { get; set; }
    }
}
