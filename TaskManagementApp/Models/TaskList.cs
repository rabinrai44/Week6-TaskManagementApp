using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManagementApp.Models
{
    public class TaskList
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsTaskDone { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}