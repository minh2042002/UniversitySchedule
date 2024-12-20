using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class MeetingTime
{
    public int Id { get; set; }

    public DayOfWeek Day { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
