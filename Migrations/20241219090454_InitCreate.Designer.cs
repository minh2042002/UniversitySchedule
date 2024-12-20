﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversitySchedule.Models;

#nullable disable

namespace UniversitySchedule.Migrations
{
    [DbContext(typeof(UniversityScheduleContext))]
    [Migration("20241219090454_InitCreate")]
    partial class InitCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("InstructorCourse", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("course_id");

                    b.Property<int>("InstructorId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("instructor_id");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("InstructorCourse", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("course_id");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("department_id");

                    b.Property<int>("InstructorId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("instructor_id");

                    b.Property<int>("MeetingTimeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("meeting_time_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("room_id");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("schedule_id");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("MeetingTimeId");

                    b.HasIndex("RoomId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("Credit")
                        .HasColumnType("INTEGER")
                        .HasColumnName("credit");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("department_id");

                    b.Property<int>("MaxStudent")
                        .HasColumnType("INTEGER")
                        .HasColumnName("max_student");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<int>("NumberClass")
                        .HasColumnType("INTEGER")
                        .HasColumnName("number_class");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("DayOfBirth")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("day_of_birth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("phone");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "IX_Information_email")
                        .IsUnique();

                    b.HasIndex(new[] { "Phone" }, "IX_Information_phone")
                        .IsUnique();

                    b.ToTable("Information", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("department_id");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Instructor", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.MeetingTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("Day")
                        .HasColumnType("INTEGER")
                        .HasColumnName("day");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("end_time");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.ToTable("MeetingTime", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER")
                        .HasColumnName("capacity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Room", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER")
                        .HasColumnName("active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Schedule", (string)null);
                });

            modelBuilder.Entity("UniversitySchedule.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("password");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Username" }, "IX_User_username")
                        .IsUnique();

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("InstructorCourse", b =>
                {
                    b.HasOne("UniversitySchedule.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySchedule.Models.Instructor", null)
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniversitySchedule.Models.Class", b =>
                {
                    b.HasOne("UniversitySchedule.Models.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySchedule.Models.Department", "Department")
                        .WithMany("Classes")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySchedule.Models.Instructor", "Instructor")
                        .WithMany("Classes")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySchedule.Models.MeetingTime", "MeetingTime")
                        .WithMany("Classes")
                        .HasForeignKey("MeetingTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySchedule.Models.Room", "Room")
                        .WithMany("Classes")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySchedule.Models.Schedule", "Schedule")
                        .WithMany("Classes")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");

                    b.Navigation("Instructor");

                    b.Navigation("MeetingTime");

                    b.Navigation("Room");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Course", b =>
                {
                    b.HasOne("UniversitySchedule.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Information", b =>
                {
                    b.HasOne("UniversitySchedule.Models.User", "User")
                        .WithOne("Information")
                        .HasForeignKey("UniversitySchedule.Models.Information", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Instructor", b =>
                {
                    b.HasOne("UniversitySchedule.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySchedule.Models.User", "User")
                        .WithOne("Instructor")
                        .HasForeignKey("UniversitySchedule.Models.Instructor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Course", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Department", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Courses");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Instructor", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("UniversitySchedule.Models.MeetingTime", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Room", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("UniversitySchedule.Models.Schedule", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("UniversitySchedule.Models.User", b =>
                {
                    b.Navigation("Information")
                        .IsRequired();

                    b.Navigation("Instructor");
                });
#pragma warning restore 612, 618
        }
    }
}
