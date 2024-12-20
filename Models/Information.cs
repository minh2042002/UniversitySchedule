using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class Information
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public DateOnly DayOfBirth { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; }
}
