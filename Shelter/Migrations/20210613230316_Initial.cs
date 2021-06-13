using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Sex = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Name", "Sex", "Type" },
                values: new object[,]
                {
                    { 1, 15, "John", "Male", "cat" },
                    { 2, 15, "Robb", "Male", "cat" },
                    { 3, 11, "Sansa", "Female", "cat" },
                    { 4, 7, "Bran", "Male", "cat" },
                    { 5, 9, "Arya", "Female", "cat" },
                    { 6, 3, "Rickon", "Male", "cat" },
                    { 7, 1, "Ghost", "Male", "dog" },
                    { 8, 1, "Grey Wind", "Male", "dog" },
                    { 9, 1, "Lady", "Female", "dog" },
                    { 10, 1, "Nymeria", "Female", "dog" },
                    { 11, 1, "Summer", "Male", "dog" },
                    { 12, 1, "Shaggy Dog", "Male", "dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
