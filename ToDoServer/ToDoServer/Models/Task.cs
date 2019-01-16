using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ToDoServer.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string AccountID { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool MarkedAsDone { get; set; }
        public readonly DateTime CeatedAt;
    }
}