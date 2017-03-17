using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore2.Models
{
    public class StudentDBInitializer:System.Data.Entity.DropCreateDatabaseAlways<StudentDBContext>
    {
        protected override void Seed(StudentDBContext context)
        {
            context.Students.AddRange(new List<Student>()
            {
                new Student(){Name="wang"},
                new Student(){Name="yan"},
                new Student(){Name="yan"},
                new Student(){Name="yan"},
                new Student(){Name="yan"},
                new Student(){Name="yan"},
                new Student(){Name="gang"},
            });
            base.Seed(context);
        }
    }
}