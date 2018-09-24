using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Model;

namespace TaskManagementSystem.ViewModel
{
    public class BoardViewModel
    {
        public string Name { get; set; }
        public int TaskId { get; set; }

        public virtual Board Board { get; set; }
        
    }
}
