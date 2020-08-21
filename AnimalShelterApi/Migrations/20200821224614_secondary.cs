using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AdoptionFee", "AnimalDescription", "AnimalHealth", "AnimalName", "SuggestedHome" },
                values: new object[,]
                {
                    { 2, 50, "Discount Garfield", "Healthy, all shots take care of, neutered!", "Gabe", "Gabe mostly just sleeps, anywhere quiet without young children or dogs is preferred." },
                    { 3, 250, "Camera Blur", "Healthy, all shots take care of, neutered!", "Yeet", "Yeet is great with anyone who's high energy, terrorizes children." },
                    { 4, 1000, "Very friendly when asleep in the other room", "Afraid to check", "Xander", "Xander is the best. Really. He doesn't bite at all. I was born with 9 fingers." },
                    { 5, 250000000, "I can't remember", "Unknown", "He-Who-Sleeps", "Somewhere with alot of room and sacrifi- an influx of new faces daily." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);
        }
    }
}
