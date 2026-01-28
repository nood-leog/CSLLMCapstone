using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSLLMCapstone.Migrations
{
    /// <inheritdoc />
    public partial class SeedUniversityCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseDesc", "Title" },
                values: new object[,]
                {
                    { 102, "test desc", "Health and Technology" },
                    { 105, "test desc", "The Logical Basis of Computing" },
                    { 107, "test desc", "Make a Game with Computer Science" },
                    { 109, "test desc", "Quantitative Reasoning Using Python" },
                    { 110, "test desc", "Programming Fundamentals I" },
                    { 111, "test desc", "Programming Fundamentals II" },
                    { 112, "test desc", "Introduction to Data Science in Python" },
                    { 301, "test desc", "Data Structures" },
                    { 302, "test desc", "Advanced Data Structures and File Processing" },
                    { 311, "test desc", "Computer Architecture I" },
                    { 312, "test desc", "Computer Architecture II" },
                    { 325, "test desc", "Technical Writing in Computer Science" },
                    { 351, "test desc", "Web Development Technologies II" },
                    { 361, "test desc", "Principles of Language Design I" },
                    { 362, "test desc", "Principles of Language Design II" },
                    { 367, "test desc", "Advanced Visual Basic Programming" },
                    { 370, "test desc", "Introduction to Linux" },
                    { 380, "test desc", "Introduction to Software Engineering" },
                    { 420, "test desc", "Database Management Systems" },
                    { 427, "test desc", "Algorithm Analysis" },
                    { 428, "test desc", "Introduction to Graph Algorithm" },
                    { 430, "test desc", "Cybersecurity" },
                    { 440, "test desc", "Computer Graphics" },
                    { 445, "test desc", "Data and Information Visualization" },
                    { 446, "test desc", "User Interface Design and Development" },
                    { 450, "test desc", "Computer Network and Data Communications" },
                    { 452, "test desc", "Ethical Hacking and Penetration Testing for Computer Science" },
                    { 456, "test desc", "Data Mining" },
                    { 457, "test desc", "Computational Intelligence and Machine Learning" },
                    { 460, "test desc", "Software Engineering for Mobile Devices" },
                    { 465, "test desc", "Scientific Computing" },
                    { 466, "test desc", "Virtual Reality" },
                    { 467, "test desc", "Computational Statistics" },
                    { 470, "test desc", "Operating Systems" },
                    { 471, "test desc", "Optimization" },
                    { 473, "test desc", "Parallel Computing" },
                    { 480, "test desc", "Advanced Software Engineering" },
                    { 481, "test desc", "Capstone Project" },
                    { 489, "test desc", "Senior Colloquium" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "CourseId", "Name", "TopicDesc" },
                values: new object[,]
                {
                    { 1, 102, "Big Tech", "test desc" },
                    { 2, 102, "Video Games", "test desc" },
                    { 3, 102, "Telemedicine", "test desc" },
                    { 4, 102, "AI", "test desc" },
                    { 5, 102, "Robotis", "test desc" },
                    { 6, 102, "Deep Web", "test desc" },
                    { 7, 102, "VR", "test desc" },
                    { 8, 102, "Music Technology", "test desc" },
                    { 9, 102, "Wearables", "test desc" },
                    { 10, 102, "Ethics", "test desc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 102);
        }
    }
}
