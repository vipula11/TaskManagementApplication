using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementDAL.Models
{
    class Task
    {
        private string id { get; set;}
        private string taskTypeId { get; set; }
        private string stateId { get; set; }
        private string title { get; set; }
        private string description { get; set; }
        private string asingee { get; set; }
        private string reporter { get; set; }
        private string listOfComments { get; set; }
        private string duration { get; set; }

        private string refTaskId { get; set; }

    }
}
