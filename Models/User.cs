using System;
using System.Collections.Generic;

namespace UniversitySchedule.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public Role Role { get; set; }

    public virtual Information Information { get; set; }

    public virtual Instructor? Instructor { get; set; }
}

public enum Role
{
    Admin = 0,
    Instructor = 1,
}