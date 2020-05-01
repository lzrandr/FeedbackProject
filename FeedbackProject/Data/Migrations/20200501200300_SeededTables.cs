using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackProject.Migrations
{
    public partial class SeededTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName" },
                values: new object[,]
                {
                    { 1, "Java" },
                    { 2, "Python" },
                    { 3, "Javascrip" },
                    { 4, "PHP" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "ab@feedback.com", "Alin", "Bradut" },
                    { 2, "lc@feedback.com", "Larisa", "Costache" },
                    { 3, "gt@feedback.com", "George", "Trifan" },
                    { 4, "on@feedback.com", "Ovidiu", "Netoiu" }
                });

            migrationBuilder.InsertData(
                table: "TeachedCourses",
                columns: new[] { "Id", "CourseId", "TeacherId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "TeachedCourses",
                columns: new[] { "Id", "CourseId", "TeacherId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "TeachedCourses",
                columns: new[] { "Id", "CourseId", "TeacherId" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Feedback", "FeedbackWriterEmail", "FeedbackWriterName", "TeachedCourseId" },
                values: new object[,]
                {
                    { 1, "Totul a fost bine", "a@a.com", "Bogdan Tudorica", 1 },
                    { 2, "Nu totul a fost bine", "b@b.com", "Jan Constatin", 1 },
                    { 3, "Totul a fost bine", "c@c.com", "Lili Horinca", 2 },
                    { 4, "Nu totul a fost bine", "d@d.com", "Bogdan Sava", 2 },
                    { 5, "Nu totul a fost bine", "c@c.com", "Ioana Constatin", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeachedCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeachedCourses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeachedCourses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
