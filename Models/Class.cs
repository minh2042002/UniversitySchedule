using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class Class
{
    public int Id { get; set; }

    public int CourseId { get; set; }

    public int InstructorId { get; set; }

    public int RoomId { get; set; }

    public int MeetingTimeId { get; set; }

    public int DepartmentId { get; set; }

    public int ScheduleId { get; set; }

    public virtual Course Course { get; set; }

    public virtual Department Department { get; set; }

    public virtual Instructor Instructor { get; set; }

    public virtual MeetingTime MeetingTime { get; set; }

    public virtual Room Room { get; set; }

    public virtual Schedule Schedule { get; set; }
}
