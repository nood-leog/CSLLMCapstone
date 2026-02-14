using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSLLMCapstone.Migrations
{
    /// <inheritdoc />
    public partial class AddIsFavoriteCourseIdCourseTitleToInstance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Instances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CourseTitle",
                table: "Instances",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Instances",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "CourseTitle",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Instances");
        }
    }
}
