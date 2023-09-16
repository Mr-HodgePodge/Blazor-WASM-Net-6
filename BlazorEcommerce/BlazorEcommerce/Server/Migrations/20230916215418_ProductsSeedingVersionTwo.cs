using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductsSeedingVersionTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Masters of Doom: How Two Guys Created an Empire and Transformed Pop Culture is a 2003 book by David Kushner about video game company id Software and its influence on popular culture, focusing on co-founders John Carmack and John Romero.", "https://upload.wikimedia.org/wikipedia/en/5/53/Masters_of_doom-Book_cover.jpg", 9.99m, "Masters of Doom" },
                    { 2, "Foucault's Pendulum (original title: Il pendolo di Foucault [il ˈpɛndolo di fuˈko]) is a novel by Italian writer and philosopher Umberto Eco. It was first published in 1988, and an English translation by William Weaver appeared a year later.", "https://upload.wikimedia.org/wikipedia/en/0/09/FoucaultsPendulum.jpg", 7.49m, "Foucault's Pendulum" },
                    { 3, "Morals and Dogma of the Ancient and Accepted Scottish Rite of Freemasonry, or simply Morals and Dogma, is a book of esoteric philosophy published by the Supreme Council, Thirty Third Degree, of the Scottish Rite, Southern Jurisdiction of the United States", "https://moly.hu/system/covers/big/covers_460628.jpg", 19.99m, "Morals and Dogma" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
