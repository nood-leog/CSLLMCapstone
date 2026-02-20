using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSLLMCapstone.Migrations
{
    /// <inheritdoc />
    public partial class AddTopicNameToInstance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TopicName",
                table: "Instances",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopicName",
                table: "Instances");
        }
    }
}
