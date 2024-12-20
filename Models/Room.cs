using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class Room
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Capacity { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
