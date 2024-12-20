using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
