using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoMvc.Models
{
    public class Todo
    {
        public int Id { get; set; }
        //cv
        public string Description { get; set; } 
        public bool IsDone { get; set; }
        public virtual ApplicationUser User { get; set; }

        public static implicit operator Todo(ApplicationUser v)
        {
            throw new NotImplementedException();
        }
    }
}