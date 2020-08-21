using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdoptionFee = table.Column<int>(nullable: false),
                    AnimalName = table.Column<string>(nullable: true),
                    AnimalDescription = table.Column<string>(nullable: true),
                    AnimalHealth = table.Column<string>(nullable: true),
                    SuggestedHome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AdoptionFee", "AnimalDescription", "AnimalHealth", "AnimalName", "SuggestedHome" },
                values: new object[] { 1, 0, "Chonky Boi", "Healthy, all shots take care of, neutered!", "Toby", "Toby is great with kids and an active environment, is also able to relax comfortably by himself or with cats, is afraid of other dogs." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
