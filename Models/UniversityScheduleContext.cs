using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UniversitySchedule.Models;

public partial class UniversityScheduleContext : DbContext
{
    public UniversityScheduleContext()
    {
    }

    public UniversityScheduleContext(DbContextOptions<UniversityScheduleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Information> Informations { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<MeetingTime> MeetingTimes { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={Application.StartupPath}\\data\\UniversitySchedule.db");
        string dbDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        if (!Directory.Exists(dbDirectory))
        {
            Directory.CreateDirectory(dbDirectory);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.ToTable("Class");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.InstructorId).HasColumnName("instructor_id");
            entity.Property(e => e.MeetingTimeId).HasColumnName("meeting_time_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");

            entity.HasOne(d => d.Course).WithMany(p => p.Classes).HasForeignKey(d => d.CourseId);

            entity.HasOne(d => d.Department).WithMany(p => p.Classes).HasForeignKey(d => d.DepartmentId);

            entity.HasOne(d => d.Instructor).WithMany(p => p.Classes).HasForeignKey(d => d.InstructorId);

            entity.HasOne(d => d.MeetingTime).WithMany(p => p.Classes).HasForeignKey(d => d.MeetingTimeId);

            entity.HasOne(d => d.Room).WithMany(p => p.Classes).HasForeignKey(d => d.RoomId);

            entity.HasOne(d => d.Schedule).WithMany(p => p.Classes).HasForeignKey(d => d.ScheduleId);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.MaxStudent).HasColumnName("max_student");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NumberClass).HasColumnName("number_class");

            entity.HasOne(d => d.Department).WithMany(p => p.Courses).HasForeignKey(d => d.DepartmentId);

            entity.HasMany(d => d.Instructors).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "InstructorCourse",
                    r => r.HasOne<Instructor>().WithMany().HasForeignKey("InstructorId"),
                    l => l.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    j =>
                    {
                        j.HasKey("CourseId", "InstructorId");
                        j.ToTable("InstructorCourse");
                        j.IndexerProperty<int>("CourseId").HasColumnName("course_id");
                        j.IndexerProperty<int>("InstructorId").HasColumnName("instructor_id");
                    });
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Information>(entity =>
        {
            entity.ToTable("Information");

            entity.HasIndex(e => e.Email, "IX_Information_email").IsUnique();
            entity.HasIndex(e => e.Phone, "IX_Information_phone").IsUnique();
             
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayOfBirth)
                    .HasColumnName("day_of_birth")
                    .HasConversion(
                        v => v.ToString("yyyy-MM-dd"),
                        v => DateOnly.Parse(v)
                    );
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithOne(p => p.Information).HasForeignKey<Information>(d => d.UserId).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.ToTable("Instructor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Department).WithMany(p => p.Instructors).HasForeignKey(d => d.DepartmentId);

            entity.HasOne(d => d.User).WithOne(p => p.Instructor).HasForeignKey<Instructor>(d => d.UserId).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<MeetingTime>(entity =>
        {
            entity.ToTable("MeetingTime");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.Day)
                    .HasColumnName("day")
                    .HasConversion<int>();
            entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasConversion(
                        v => v.ToString("HH:mm"),
                        v => TimeOnly.ParseExact(v, "HH:mm")
                    );
            entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasConversion(
                        v => v.ToString("HH:mm"),
                        v => TimeOnly.ParseExact(v, "HH:mm")
                    );
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.ToTable("Schedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("active");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.Username, "IX_User_username").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasConversion<int>();
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<MeetingTime>().HasData(
            Enumerable.Range(1, 5) 
                .SelectMany(i =>
                {
                    var day = (DayOfWeek)i;
                    return new List<MeetingTime>
                    {
                        // Credit = 2
                        new MeetingTime { Id = i * 10 + 1, Credit = 2, Day = day, StartTime = TimeOnly.Parse("06:45"), EndTime = TimeOnly.Parse("08:15") },
                        new MeetingTime { Id = i * 10 + 2, Credit = 2, Day = day, StartTime = TimeOnly.Parse("08:25"), EndTime = TimeOnly.Parse("10:05") },
                        new MeetingTime { Id = i * 10 + 3, Credit = 2, Day = day, StartTime = TimeOnly.Parse("10:15"), EndTime = TimeOnly.Parse("11:45") },
                        new MeetingTime { Id = i * 10 + 4, Credit = 2, Day = day, StartTime = TimeOnly.Parse("12:30"), EndTime = TimeOnly.Parse("14:00") },
                        new MeetingTime { Id = i * 10 + 5, Credit = 2, Day = day, StartTime = TimeOnly.Parse("14:10"), EndTime = TimeOnly.Parse("15:50") },
                        new MeetingTime { Id = i * 10 + 6, Credit = 2, Day = day, StartTime = TimeOnly.Parse("16:00"), EndTime = TimeOnly.Parse("17:30") },
        
                        // Credit = 3
                        new MeetingTime { Id = i * 10 + 7, Credit = 3, Day = day, StartTime = TimeOnly.Parse("06:45"), EndTime = TimeOnly.Parse("09:10") },
                        new MeetingTime { Id = i * 10 + 8, Credit = 3, Day = day, StartTime = TimeOnly.Parse("09:20"), EndTime = TimeOnly.Parse("11:45") },
                        new MeetingTime { Id = i * 10 + 9, Credit = 3, Day = day, StartTime = TimeOnly.Parse("12:30"), EndTime = TimeOnly.Parse("14:55") },
                        new MeetingTime { Id = i * 10 + 10, Credit = 3, Day = day, StartTime = TimeOnly.Parse("15:05"), EndTime = TimeOnly.Parse("17:30") }
                    };
                }).ToArray()
        );


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
