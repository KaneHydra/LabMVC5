using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LabMVC5.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudNo = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "CName", "Feedback", "StudNo", "Year" },
                values: new object[,]
                {
                    { 1, "AAA", "...", "1", 1972 },
                    { 2, "BBB", "...", "2", 1972 },
                    { 3, "CCC", "...", "3", 1972 },
                    { 4, "DDD", "...", "4", 1972 },
                    { 5, "EEE", "...", "5", 1972 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
