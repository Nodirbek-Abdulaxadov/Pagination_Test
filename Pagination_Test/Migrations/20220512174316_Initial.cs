using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pagination_Test.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Faculty", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 2, "Math", "Mr. Tom", "Any" },
                    { 2, 3, "Math", "Mr. Tom", "Any" },
                    { 3, 4, "Math", "Mr. Tom", "Any" },
                    { 4, 5, "Math", "Mr. Tom", "Any" },
                    { 5, 6, "Math", "Mr. Tom", "Any" },
                    { 6, 7, "Math", "Mr. Tom", "Any" },
                    { 7, 8, "Math", "Mr. Tom", "Any" },
                    { 8, 9, "Math", "Mr. Tom", "Any" },
                    { 9, 10, "Math", "Mr. Tom", "Any" },
                    { 10, 11, "Math", "Mr. Tom", "Any" },
                    { 11, 12, "Math", "Mr. Tom", "Any" },
                    { 12, 13, "Math", "Mr. Tom", "Any" },
                    { 13, 14, "Math", "Mr. Tom", "Any" },
                    { 14, 15, "Math", "Mr. Tom", "Any" },
                    { 15, 16, "Math", "Mr. Tom", "Any" },
                    { 16, 17, "Math", "Mr. Tom", "Any" },
                    { 17, 18, "Math", "Mr. Tom", "Any" },
                    { 18, 19, "Math", "Mr. Tom", "Any" },
                    { 19, 20, "Math", "Mr. Tom", "Any" },
                    { 20, 21, "Math", "Mr. Tom", "Any" },
                    { 21, 22, "Math", "Mr. Tom", "Any" },
                    { 22, 23, "Math", "Mr. Tom", "Any" },
                    { 23, 24, "Math", "Mr. Tom", "Any" },
                    { 24, 25, "Math", "Mr. Tom", "Any" },
                    { 25, 26, "Math", "Mr. Tom", "Any" },
                    { 26, 27, "Math", "Mr. Tom", "Any" },
                    { 27, 28, "Math", "Mr. Tom", "Any" },
                    { 28, 29, "Math", "Mr. Tom", "Any" },
                    { 29, 30, "Math", "Mr. Tom", "Any" },
                    { 30, 31, "Math", "Mr. Tom", "Any" },
                    { 31, 32, "Math", "Mr. Tom", "Any" },
                    { 32, 33, "Math", "Mr. Tom", "Any" },
                    { 33, 34, "Math", "Mr. Tom", "Any" },
                    { 34, 35, "Math", "Mr. Tom", "Any" },
                    { 35, 36, "Math", "Mr. Tom", "Any" },
                    { 36, 37, "Math", "Mr. Tom", "Any" },
                    { 37, 38, "Math", "Mr. Tom", "Any" },
                    { 38, 39, "Math", "Mr. Tom", "Any" },
                    { 39, 40, "Math", "Mr. Tom", "Any" },
                    { 40, 41, "Math", "Mr. Tom", "Any" },
                    { 41, 42, "Math", "Mr. Tom", "Any" },
                    { 42, 43, "Math", "Mr. Tom", "Any" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Faculty", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 43, 44, "Math", "Mr. Tom", "Any" },
                    { 44, 45, "Math", "Mr. Tom", "Any" },
                    { 45, 46, "Math", "Mr. Tom", "Any" },
                    { 46, 47, "Math", "Mr. Tom", "Any" },
                    { 47, 48, "Math", "Mr. Tom", "Any" },
                    { 48, 49, "Math", "Mr. Tom", "Any" },
                    { 49, 50, "Math", "Mr. Tom", "Any" },
                    { 50, 51, "Math", "Mr. Tom", "Any" },
                    { 51, 52, "Math", "Mr. Tom", "Any" },
                    { 52, 53, "Math", "Mr. Tom", "Any" },
                    { 53, 54, "Math", "Mr. Tom", "Any" },
                    { 54, 55, "Math", "Mr. Tom", "Any" },
                    { 55, 56, "Math", "Mr. Tom", "Any" },
                    { 56, 57, "Math", "Mr. Tom", "Any" },
                    { 57, 58, "Math", "Mr. Tom", "Any" },
                    { 58, 59, "Math", "Mr. Tom", "Any" },
                    { 59, 60, "Math", "Mr. Tom", "Any" },
                    { 60, 61, "Math", "Mr. Tom", "Any" },
                    { 61, 62, "Math", "Mr. Tom", "Any" },
                    { 62, 63, "Math", "Mr. Tom", "Any" },
                    { 63, 64, "Math", "Mr. Tom", "Any" },
                    { 64, 65, "Math", "Mr. Tom", "Any" },
                    { 65, 66, "Math", "Mr. Tom", "Any" },
                    { 66, 67, "Math", "Mr. Tom", "Any" },
                    { 67, 68, "Math", "Mr. Tom", "Any" },
                    { 68, 69, "Math", "Mr. Tom", "Any" },
                    { 69, 70, "Math", "Mr. Tom", "Any" },
                    { 70, 71, "Math", "Mr. Tom", "Any" },
                    { 71, 72, "Math", "Mr. Tom", "Any" },
                    { 72, 73, "Math", "Mr. Tom", "Any" },
                    { 73, 74, "Math", "Mr. Tom", "Any" },
                    { 74, 75, "Math", "Mr. Tom", "Any" },
                    { 75, 76, "Math", "Mr. Tom", "Any" },
                    { 76, 77, "Math", "Mr. Tom", "Any" },
                    { 77, 78, "Math", "Mr. Tom", "Any" },
                    { 78, 79, "Math", "Mr. Tom", "Any" },
                    { 79, 80, "Math", "Mr. Tom", "Any" },
                    { 80, 81, "Math", "Mr. Tom", "Any" },
                    { 81, 82, "Math", "Mr. Tom", "Any" },
                    { 82, 83, "Math", "Mr. Tom", "Any" },
                    { 83, 84, "Math", "Mr. Tom", "Any" },
                    { 84, 85, "Math", "Mr. Tom", "Any" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Faculty", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 85, 86, "Math", "Mr. Tom", "Any" },
                    { 86, 87, "Math", "Mr. Tom", "Any" },
                    { 87, 88, "Math", "Mr. Tom", "Any" },
                    { 88, 89, "Math", "Mr. Tom", "Any" },
                    { 89, 90, "Math", "Mr. Tom", "Any" },
                    { 90, 91, "Math", "Mr. Tom", "Any" },
                    { 91, 92, "Math", "Mr. Tom", "Any" },
                    { 92, 93, "Math", "Mr. Tom", "Any" },
                    { 93, 94, "Math", "Mr. Tom", "Any" },
                    { 94, 95, "Math", "Mr. Tom", "Any" },
                    { 95, 96, "Math", "Mr. Tom", "Any" },
                    { 96, 97, "Math", "Mr. Tom", "Any" },
                    { 97, 98, "Math", "Mr. Tom", "Any" },
                    { 98, 99, "Math", "Mr. Tom", "Any" },
                    { 99, 100, "Math", "Mr. Tom", "Any" },
                    { 100, 101, "Math", "Mr. Tom", "Any" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
