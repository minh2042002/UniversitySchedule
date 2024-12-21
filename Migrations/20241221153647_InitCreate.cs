using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniversitySchedule.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingTime",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    credit = table.Column<int>(type: "INTEGER", nullable: false),
                    day = table.Column<int>(type: "INTEGER", nullable: false),
                    start_time = table.Column<string>(type: "TEXT", nullable: false),
                    end_time = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingTime", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    capacity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false),
                    role = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    credit = table.Column<int>(type: "INTEGER", nullable: false),
                    max_student = table.Column<int>(type: "INTEGER", nullable: false),
                    number_class = table.Column<int>(type: "INTEGER", nullable: false),
                    department_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.id);
                    table.ForeignKey(
                        name: "FK_Course_Department_department_id",
                        column: x => x.department_id,
                        principalTable: "Department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    phone = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    day_of_birth = table.Column<string>(type: "TEXT", nullable: false),
                    user_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.id);
                    table.ForeignKey(
                        name: "FK_Information_User_user_id",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    department_id = table.Column<int>(type: "INTEGER", nullable: false),
                    user_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.id);
                    table.ForeignKey(
                        name: "FK_Instructor_Department_department_id",
                        column: x => x.department_id,
                        principalTable: "Department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructor_User_user_id",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    course_id = table.Column<int>(type: "INTEGER", nullable: false),
                    instructor_id = table.Column<int>(type: "INTEGER", nullable: false),
                    room_id = table.Column<int>(type: "INTEGER", nullable: false),
                    meeting_time_id = table.Column<int>(type: "INTEGER", nullable: false),
                    department_id = table.Column<int>(type: "INTEGER", nullable: false),
                    schedule_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.id);
                    table.ForeignKey(
                        name: "FK_Class_Course_course_id",
                        column: x => x.course_id,
                        principalTable: "Course",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Department_department_id",
                        column: x => x.department_id,
                        principalTable: "Department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Instructor_instructor_id",
                        column: x => x.instructor_id,
                        principalTable: "Instructor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_MeetingTime_meeting_time_id",
                        column: x => x.meeting_time_id,
                        principalTable: "MeetingTime",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Room_room_id",
                        column: x => x.room_id,
                        principalTable: "Room",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Schedule_schedule_id",
                        column: x => x.schedule_id,
                        principalTable: "Schedule",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorCourse",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "INTEGER", nullable: false),
                    instructor_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorCourse", x => new { x.course_id, x.instructor_id });
                    table.ForeignKey(
                        name: "FK_InstructorCourse_Course_course_id",
                        column: x => x.course_id,
                        principalTable: "Course",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorCourse_Instructor_instructor_id",
                        column: x => x.instructor_id,
                        principalTable: "Instructor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MeetingTime",
                columns: new[] { "id", "credit", "day", "end_time", "start_time" },
                values: new object[,]
                {
                    { 11, 2, 1, "08:15", "06:45" },
                    { 12, 2, 1, "10:05", "08:25" },
                    { 13, 2, 1, "11:45", "10:15" },
                    { 14, 2, 1, "14:00", "12:30" },
                    { 15, 2, 1, "15:50", "14:10" },
                    { 16, 2, 1, "17:30", "16:00" },
                    { 17, 3, 1, "09:10", "06:45" },
                    { 18, 3, 1, "11:45", "09:20" },
                    { 19, 3, 1, "14:55", "12:30" },
                    { 20, 3, 1, "17:30", "15:05" },
                    { 21, 2, 2, "08:15", "06:45" },
                    { 22, 2, 2, "10:05", "08:25" },
                    { 23, 2, 2, "11:45", "10:15" },
                    { 24, 2, 2, "14:00", "12:30" },
                    { 25, 2, 2, "15:50", "14:10" },
                    { 26, 2, 2, "17:30", "16:00" },
                    { 27, 3, 2, "09:10", "06:45" },
                    { 28, 3, 2, "11:45", "09:20" },
                    { 29, 3, 2, "14:55", "12:30" },
                    { 30, 3, 2, "17:30", "15:05" },
                    { 31, 2, 3, "08:15", "06:45" },
                    { 32, 2, 3, "10:05", "08:25" },
                    { 33, 2, 3, "11:45", "10:15" },
                    { 34, 2, 3, "14:00", "12:30" },
                    { 35, 2, 3, "15:50", "14:10" },
                    { 36, 2, 3, "17:30", "16:00" },
                    { 37, 3, 3, "09:10", "06:45" },
                    { 38, 3, 3, "11:45", "09:20" },
                    { 39, 3, 3, "14:55", "12:30" },
                    { 40, 3, 3, "17:30", "15:05" },
                    { 41, 2, 4, "08:15", "06:45" },
                    { 42, 2, 4, "10:05", "08:25" },
                    { 43, 2, 4, "11:45", "10:15" },
                    { 44, 2, 4, "14:00", "12:30" },
                    { 45, 2, 4, "15:50", "14:10" },
                    { 46, 2, 4, "17:30", "16:00" },
                    { 47, 3, 4, "09:10", "06:45" },
                    { 48, 3, 4, "11:45", "09:20" },
                    { 49, 3, 4, "14:55", "12:30" },
                    { 50, 3, 4, "17:30", "15:05" },
                    { 51, 2, 5, "08:15", "06:45" },
                    { 52, 2, 5, "10:05", "08:25" },
                    { 53, 2, 5, "11:45", "10:15" },
                    { 54, 2, 5, "14:00", "12:30" },
                    { 55, 2, 5, "15:50", "14:10" },
                    { 56, 2, 5, "17:30", "16:00" },
                    { 57, 3, 5, "09:10", "06:45" },
                    { 58, 3, 5, "11:45", "09:20" },
                    { 59, 3, 5, "14:55", "12:30" },
                    { 60, 3, 5, "17:30", "15:05" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_course_id",
                table: "Class",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_department_id",
                table: "Class",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_instructor_id",
                table: "Class",
                column: "instructor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_meeting_time_id",
                table: "Class",
                column: "meeting_time_id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_room_id",
                table: "Class",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_schedule_id",
                table: "Class",
                column: "schedule_id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_department_id",
                table: "Course",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_Information_email",
                table: "Information",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Information_phone",
                table: "Information",
                column: "phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Information_user_id",
                table: "Information",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_department_id",
                table: "Instructor",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_user_id",
                table: "Instructor",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourse_instructor_id",
                table: "InstructorCourse",
                column: "instructor_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_username",
                table: "User",
                column: "username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Information");

            migrationBuilder.DropTable(
                name: "InstructorCourse");

            migrationBuilder.DropTable(
                name: "MeetingTime");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
