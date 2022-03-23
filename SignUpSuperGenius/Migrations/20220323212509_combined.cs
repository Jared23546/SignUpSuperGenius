using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUpSuperGenius.Migrations
{
    public partial class combined : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Day = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Filled = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<ushort>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 1, "Monday", null, false, null, null, (ushort)0, "8:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 66, "Saturday", null, false, null, null, (ushort)0, "8:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 65, "Friday", null, false, null, null, (ushort)0, "8:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 64, "Friday", null, false, null, null, (ushort)0, "7:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 63, "Friday", null, false, null, null, (ushort)0, "6:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 62, "Friday", null, false, null, null, (ushort)0, "5:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 61, "Friday", null, false, null, null, (ushort)0, "4:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 60, "Friday", null, false, null, null, (ushort)0, "3:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 59, "Friday", null, false, null, null, (ushort)0, "2:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 58, "Friday", null, false, null, null, (ushort)0, "1:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 57, "Friday", null, false, null, null, (ushort)0, "12:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 56, "Friday", null, false, null, null, (ushort)0, "11:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 55, "Friday", null, false, null, null, (ushort)0, "10:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 54, "Friday", null, false, null, null, (ushort)0, "9:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 53, "Friday", null, false, null, null, (ushort)0, "8:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 52, "Thursday", null, false, null, null, (ushort)0, "8:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 51, "Thursday", null, false, null, null, (ushort)0, "7:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 50, "Thursday", null, false, null, null, (ushort)0, "6:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 49, "Thursday", null, false, null, null, (ushort)0, "5:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 48, "Thursday", null, false, null, null, (ushort)0, "4:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 67, "Saturday", null, false, null, null, (ushort)0, "9:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 47, "Thursday", null, false, null, null, (ushort)0, "3:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 68, "Saturday", null, false, null, null, (ushort)0, "10:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 70, "Saturday", null, false, null, null, (ushort)0, "12:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 89, "Sunday", null, false, null, null, (ushort)0, "6:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 88, "Sunday", null, false, null, null, (ushort)0, "5:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 87, "Sunday", null, false, null, null, (ushort)0, "4:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 86, "Sunday", null, false, null, null, (ushort)0, "3:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 85, "Sunday", null, false, null, null, (ushort)0, "2:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 84, "Sunday", null, false, null, null, (ushort)0, "1:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 83, "Sunday", null, false, null, null, (ushort)0, "12:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 82, "Sunday", null, false, null, null, (ushort)0, "11:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 81, "Sunday", null, false, null, null, (ushort)0, "10:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 80, "Sunday", null, false, null, null, (ushort)0, "9:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 79, "Sunday", null, false, null, null, (ushort)0, "8:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 78, "Saturday", null, false, null, null, (ushort)0, "8:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 77, "Saturday", null, false, null, null, (ushort)0, "7:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 76, "Saturday", null, false, null, null, (ushort)0, "6:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 75, "Saturday", null, false, null, null, (ushort)0, "5:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 74, "Saturday", null, false, null, null, (ushort)0, "4:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 73, "Saturday", null, false, null, null, (ushort)0, "3:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 72, "Saturday", null, false, null, null, (ushort)0, "2:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 71, "Saturday", null, false, null, null, (ushort)0, "1:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 69, "Saturday", null, false, null, null, (ushort)0, "11:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 90, "Sunday", null, false, null, null, (ushort)0, "7:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 46, "Thursday", null, false, null, null, (ushort)0, "2:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 44, "Thursday", null, false, null, null, (ushort)0, "12:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 20, "Tuesday", null, false, null, null, (ushort)0, "2:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 19, "Tuesday", null, false, null, null, (ushort)0, "1:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 18, "Tuesday", null, false, null, null, (ushort)0, "12:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 17, "Tuesday", null, false, null, null, (ushort)0, "11:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 16, "Tuesday", null, false, null, null, (ushort)0, "10:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 15, "Tuesday", null, false, null, null, (ushort)0, "9:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 14, "Tuesday", null, false, null, null, (ushort)0, "8:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 13, "Monday", null, false, null, null, (ushort)0, "8:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 12, "Monday", null, false, null, null, (ushort)0, "7:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 11, "Monday", null, false, null, null, (ushort)0, "6:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 10, "Monday", null, false, null, null, (ushort)0, "5:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 9, "Monday", null, false, null, null, (ushort)0, "4:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 8, "Monday", null, false, null, null, (ushort)0, "3:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 7, "Monday", null, false, null, null, (ushort)0, "2:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 6, "Monday", null, false, null, null, (ushort)0, "1:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 5, "Monday", null, false, null, null, (ushort)0, "12:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 4, "Monday", null, false, null, null, (ushort)0, "11:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 3, "Monday", null, false, null, null, (ushort)0, "10:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 2, "Monday", null, false, null, null, (ushort)0, "9:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 21, "Tuesday", null, false, null, null, (ushort)0, "3:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 45, "Thursday", null, false, null, null, (ushort)0, "1:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 22, "Tuesday", null, false, null, null, (ushort)0, "4:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 24, "Tuesday", null, false, null, null, (ushort)0, "6:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 43, "Thursday", null, false, null, null, (ushort)0, "11:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 42, "Thursday", null, false, null, null, (ushort)0, "10:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 41, "Thursday", null, false, null, null, (ushort)0, "9:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 40, "Thursday", null, false, null, null, (ushort)0, "8:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 39, "Wednesday", null, false, null, null, (ushort)0, "8:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 38, "Wednesday", null, false, null, null, (ushort)0, "7:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 37, "Wednesday", null, false, null, null, (ushort)0, "6:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 36, "Wednesday", null, false, null, null, (ushort)0, "5:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 35, "Wednesday", null, false, null, null, (ushort)0, "4:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 34, "Wednesday", null, false, null, null, (ushort)0, "3:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 33, "Wednesday", null, false, null, null, (ushort)0, "2:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 32, "Wednesday", null, false, null, null, (ushort)0, "1:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 31, "Wednesday", null, false, null, null, (ushort)0, "12:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 30, "Wednesday", null, false, null, null, (ushort)0, "11:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 29, "Wednesday", null, false, null, null, (ushort)0, "10:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 28, "Wednesday", null, false, null, null, (ushort)0, "9:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 27, "Wednesday", null, false, null, null, (ushort)0, "8:00am" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 26, "Tuesday", null, false, null, null, (ushort)0, "8:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 25, "Tuesday", null, false, null, null, (ushort)0, "7:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 23, "Tuesday", null, false, null, null, (ushort)0, "5:00pm" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Day", "Email", "Filled", "Name", "PhoneNumber", "Size", "Time" },
                values: new object[] { 91, "Sunday", null, false, null, null, (ushort)0, "8:00pm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
