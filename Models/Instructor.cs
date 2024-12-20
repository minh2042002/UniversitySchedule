using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual Department Department { get; set; }

    public virtual User User { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
