using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversitySchedule.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Credit { get; set; }

    public int MaxStudent { get; set; }

    public int NumberClass { get; set; }

    public int DepartmentId { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual Department Department { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
