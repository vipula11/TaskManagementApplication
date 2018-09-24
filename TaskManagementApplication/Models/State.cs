using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TaskManagementSystem.Model
{
    [Table("State")]
    public class State
    {
        public State()
        {
            MainTasks = new HashSet<MainTask>();
        }

        [Required, Display(Name = "State Id")]
        public int StateId { get; set; }

        [Required, Display(Name = "Type"), StringLength(15)]
        public string Type { get; set; }

        public virtual ICollection<MainTask> MainTasks { get; set; }
    }
}
