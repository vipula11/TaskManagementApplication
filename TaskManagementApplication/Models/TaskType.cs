using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Model
{
    [Table("TaskType")]
    public class TaskType
    {
        public TaskType()
        {
            
        }

        [Required]
        public virtual int PhoneTypeId
        {
            get
            {
                return (int)this.PhoneType;
            }
            set
            {
                PhoneType = (TaskTypeEnum)value;
            }
        }
        [EnumDataType(typeof(TaskTypeEnum))]
        public TaskTypeEnum PhoneType { get; set; }
        public enum TaskTypeEnum
        {
            Story = 1,
            SubTask = 2,
            Bug = 3,
            Feature = 4,
            Improvement = 5
        }
    }
}
