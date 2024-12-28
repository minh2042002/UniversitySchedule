using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class Schedule
{
    public int Id { get; set; }
    public string Name { get; set; } = DateTime.Now.ToString();
    public bool IsActive { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
