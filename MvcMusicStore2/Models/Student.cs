using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore2.Models
{
    public class Student
    {
        [Key]
        public virtual int StudnetID { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
    }
}