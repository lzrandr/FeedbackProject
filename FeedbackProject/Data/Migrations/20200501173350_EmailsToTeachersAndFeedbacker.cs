using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackProject.Migrations
{
    public partial class EmailsToTeachersAndFeedbacker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeedbackWriterEmail",
                table: "Feedbacks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeedbackWriterName",
                table: "Feedbacks",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FeedbackWriterEmail",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "FeedbackWriterName",
                table: "Feedbacks");
        }
    }
}
