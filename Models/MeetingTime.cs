using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class MeetingTime
{
    public int Id { get; set; }

    public int Credit { get; set; }

    public DayOfWeek Day { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public MeetingTime() { }

    public MeetingTime(int id, int credit, DayOfWeek day, TimeOnly startTime, TimeOnly endTime)
    {
        Id = id;
        Credit = credit;
        Day = day;
        StartTime = startTime;
        EndTime = endTime;
    }

    public bool IsTimeConflict(MeetingTime mt)
    {
        if (Day != mt.Day)
        {
            return false;
        }
        return StartTime < mt.EndTime && this.EndTime > mt.StartTime;
    }

    public override string ToString()
    {
        return $"{StartTime.ToString("HH:mm")} -> {EndTime.ToString("HH:mm")}";
    }
}
