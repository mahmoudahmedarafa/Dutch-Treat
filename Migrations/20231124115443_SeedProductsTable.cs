using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dutch_Treat.Migrations
{
    public partial class SeedProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ArtDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 1, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 89.99m, "48\" x 36\"", "Self-portrait" },
                    { 2, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 59.99m, "32\" x 24\"", "Self-portrait" },
                    { 3, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 29.99m, "24\" x 18\"", "Self-portrait" },
                    { 4, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Mug", 19.99m, "12oz", "Self-portrait" },
                    { 5, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Small", "Self-portrait" },
                    { 6, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Medium", "Self-portrait" },
                    { 7, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Large", "Self-portrait" },
                    { 8, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "XL", "Self-portrait" },
                    { 9, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "2XL", "Self-portrait" },
                    { 10, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "3XL", "Self-portrait" },
                    { 11, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 89.99m, "48\" x 36\"", "Farming Village at Twilight" },
                    { 12, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 59.99m, "32\" x 24\"", "Farming Village at Twilight" },
                    { 13, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 29.99m, "24\" x 18\"", "Farming Village at Twilight" },
                    { 14, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Mug", 19.99m, "12oz", "Farming Village at Twilight" },
                    { 15, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Small", "Farming Village at Twilight" },
                    { 16, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Medium", "Farming Village at Twilight" },
                    { 17, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Large", "Farming Village at Twilight" },
                    { 18, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "XL", "Farming Village at Twilight" },
                    { 19, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "2XL", "Farming Village at Twilight" },
                    { 20, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "3XL", "Farming Village at Twilight" },
                    { 21, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 89.99m, "48\" x 36\"", "Self-portrait" },
                    { 22, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 59.99m, "32\" x 24\"", "Self-portrait" },
                    { 23, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 29.99m, "24\" x 18\"", "Self-portrait" },
                    { 24, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Mug", 19.99m, "12oz", "Self-portrait" },
                    { 25, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Small", "Self-portrait" },
                    { 26, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Medium", "Self-portrait" },
                    { 27, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Large", "Self-portrait" },
                    { 28, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "XL", "Self-portrait" },
                    { 29, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "2XL", "Self-portrait" },
                    { 30, "1887", "Vincent moved to Paris in 1886, after hearing from his brother Theo about the new, colourful style of French painting. Wasting no time, he tried it out in several self-portraits. He did this mostly to avoid having to pay for a model. Using rhythmic brushstrokes in striking colours, he portrayed himself here as a fashionably dressed Parisian.", "SK-A-3262", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "3XL", "Self-portrait" },
                    { 31, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 89.99m, "48\" x 36\"", "Farming Village at Twilight" },
                    { 32, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 59.99m, "32\" x 24\"", "Farming Village at Twilight" },
                    { 33, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 29.99m, "24\" x 18\"", "Farming Village at Twilight" },
                    { 34, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Mug", 19.99m, "12oz", "Farming Village at Twilight" },
                    { 35, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Small", "Farming Village at Twilight" },
                    { 36, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Medium", "Farming Village at Twilight" },
                    { 37, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Large", "Farming Village at Twilight" },
                    { 38, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "XL", "Farming Village at Twilight" },
                    { 39, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "2XL", "Farming Village at Twilight" },
                    { 40, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "3XL", "Farming Village at Twilight" },
                    { 41, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Self Portrait as the Apostle Paul" },
                    { 42, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Self Portrait as the Apostle Paul" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 43, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Self Portrait as the Apostle Paul" },
                    { 44, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Self Portrait as the Apostle Paul" },
                    { 45, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Self Portrait as the Apostle Paul" },
                    { 46, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Self Portrait as the Apostle Paul" },
                    { 47, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Self Portrait as the Apostle Paul" },
                    { 48, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Self Portrait as the Apostle Paul" },
                    { 49, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Self Portrait as the Apostle Paul" },
                    { 50, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Self Portrait as the Apostle Paul" },
                    { 51, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 52, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 53, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 54, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 55, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 56, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 57, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 58, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 59, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 60, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 61, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 62, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 63, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 64, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 65, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 66, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 67, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 68, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 69, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 70, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 71, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Woman, Possibly Maria Trip" },
                    { 72, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Woman, Possibly Maria Trip" },
                    { 73, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Woman, Possibly Maria Trip" },
                    { 74, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Woman, Possibly Maria Trip" },
                    { 75, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Woman, Possibly Maria Trip" },
                    { 76, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Woman, Possibly Maria Trip" },
                    { 77, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Woman, Possibly Maria Trip" },
                    { 78, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Woman, Possibly Maria Trip" },
                    { 79, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Woman, Possibly Maria Trip" },
                    { 80, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Woman, Possibly Maria Trip" },
                    { 81, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Self-portrait" },
                    { 82, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Self-portrait" },
                    { 83, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Self-portrait" },
                    { 84, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Self-portrait" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 85, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Self-portrait" },
                    { 86, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Self-portrait" },
                    { 87, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Self-portrait" },
                    { 88, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Self-portrait" },
                    { 89, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Self-portrait" },
                    { 90, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Self-portrait" },
                    { 91, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 92, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 93, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 94, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 95, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 96, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 97, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 98, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 99, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 100, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 101, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait de Marten Soolmans" },
                    { 102, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait de Marten Soolmans" },
                    { 103, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait de Marten Soolmans" },
                    { 104, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait de Marten Soolmans" },
                    { 105, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait de Marten Soolmans" },
                    { 106, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait de Marten Soolmans" },
                    { 107, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait de Marten Soolmans" },
                    { 108, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait de Marten Soolmans" },
                    { 109, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait de Marten Soolmans" },
                    { 110, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait de Marten Soolmans" },
                    { 111, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of Oopjen Coppit" },
                    { 112, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of Oopjen Coppit" },
                    { 113, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of Oopjen Coppit" },
                    { 114, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of Oopjen Coppit" },
                    { 115, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of Oopjen Coppit" },
                    { 116, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of Oopjen Coppit" },
                    { 117, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of Oopjen Coppit" },
                    { 118, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of Oopjen Coppit" },
                    { 119, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of Oopjen Coppit" },
                    { 120, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of Oopjen Coppit" },
                    { 121, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Milkmaid" },
                    { 122, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Milkmaid" },
                    { 123, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Milkmaid" },
                    { 124, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Milkmaid" },
                    { 125, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Milkmaid" },
                    { 126, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Milkmaid" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 127, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Milkmaid" },
                    { 128, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Milkmaid" },
                    { 129, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Milkmaid" },
                    { 130, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Milkmaid" },
                    { 131, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Head of a Boy" },
                    { 132, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Head of a Boy" },
                    { 133, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Head of a Boy" },
                    { 134, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Head of a Boy" },
                    { 135, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Head of a Boy" },
                    { 136, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Head of a Boy" },
                    { 137, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Head of a Boy" },
                    { 138, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Head of a Boy" },
                    { 139, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Head of a Boy" },
                    { 140, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Head of a Boy" },
                    { 141, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 142, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 143, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 144, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 145, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 146, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 147, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 148, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 149, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 150, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 151, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 152, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 153, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 154, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 155, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 156, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 157, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 158, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 159, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 160, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 161, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Young Woman in Fantasy Costume" },
                    { 162, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Young Woman in Fantasy Costume" },
                    { 163, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Young Woman in Fantasy Costume" },
                    { 164, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Young Woman in Fantasy Costume" },
                    { 165, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Young Woman in Fantasy Costume" },
                    { 166, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Young Woman in Fantasy Costume" },
                    { 167, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Young Woman in Fantasy Costume" },
                    { 168, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Young Woman in Fantasy Costume" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 169, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Young Woman in Fantasy Costume" },
                    { 170, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Young Woman in Fantasy Costume" },
                    { 171, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 172, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 173, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 174, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 175, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 176, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 177, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 178, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 179, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 180, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 181, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 182, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 183, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 184, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 185, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 186, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 187, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 188, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 189, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 190, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 191, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 192, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 193, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 194, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 195, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 196, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 197, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 198, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 199, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 200, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 201, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Bust of a Laughing Young Man" },
                    { 202, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Bust of a Laughing Young Man" },
                    { 203, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Bust of a Laughing Young Man" },
                    { 204, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Bust of a Laughing Young Man" },
                    { 205, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Bust of a Laughing Young Man" },
                    { 206, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Bust of a Laughing Young Man" },
                    { 207, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Bust of a Laughing Young Man" },
                    { 208, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Bust of a Laughing Young Man" },
                    { 209, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Bust of a Laughing Young Man" },
                    { 210, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Bust of a Laughing Young Man" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 211, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Still Life with Peacocks" },
                    { 212, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Still Life with Peacocks" },
                    { 213, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Still Life with Peacocks" },
                    { 214, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Still Life with Peacocks" },
                    { 215, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Still Life with Peacocks" },
                    { 216, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Still Life with Peacocks" },
                    { 217, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Still Life with Peacocks" },
                    { 218, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Still Life with Peacocks" },
                    { 219, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Still Life with Peacocks" },
                    { 220, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Still Life with Peacocks" },
                    { 221, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Tobit and Anna with the Kid" },
                    { 222, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Tobit and Anna with the Kid" },
                    { 223, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Tobit and Anna with the Kid" },
                    { 224, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Tobit and Anna with the Kid" },
                    { 225, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Tobit and Anna with the Kid" },
                    { 226, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Tobit and Anna with the Kid" },
                    { 227, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Tobit and Anna with the Kid" },
                    { 228, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Tobit and Anna with the Kid" },
                    { 229, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Tobit and Anna with the Kid" },
                    { 230, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Tobit and Anna with the Kid" },
                    { 231, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 232, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 233, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 234, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 235, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 236, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 237, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 238, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 239, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 240, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 241, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of Johannes Wtenbogaert" },
                    { 242, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of Johannes Wtenbogaert" },
                    { 243, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of Johannes Wtenbogaert" },
                    { 244, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of Johannes Wtenbogaert" },
                    { 245, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of Johannes Wtenbogaert" },
                    { 246, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of Johannes Wtenbogaert" },
                    { 247, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of Johannes Wtenbogaert" },
                    { 248, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of Johannes Wtenbogaert" },
                    { 249, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of Johannes Wtenbogaert" },
                    { 250, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of Johannes Wtenbogaert" },
                    { 251, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Musical Company" },
                    { 252, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Musical Company" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 253, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Musical Company" },
                    { 254, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Musical Company" },
                    { 255, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Musical Company" },
                    { 256, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Musical Company" },
                    { 257, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Musical Company" },
                    { 258, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Musical Company" },
                    { 259, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Musical Company" },
                    { 260, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Musical Company" },
                    { 261, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 262, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 263, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 264, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 265, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 266, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 267, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 268, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 269, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 270, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 271, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Denial of St Peter" },
                    { 272, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Denial of St Peter" },
                    { 273, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Denial of St Peter" },
                    { 274, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Denial of St Peter" },
                    { 275, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Denial of St Peter" },
                    { 276, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Denial of St Peter" },
                    { 277, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Denial of St Peter" },
                    { 278, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Denial of St Peter" },
                    { 279, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Denial of St Peter" },
                    { 280, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Denial of St Peter" },
                    { 281, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 282, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 283, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 284, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 285, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 286, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 287, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 288, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 289, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 290, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 291, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Samson and Delilah" },
                    { 292, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Samson and Delilah" },
                    { 293, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Samson and Delilah" },
                    { 294, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Samson and Delilah" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 295, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Samson and Delilah" },
                    { 296, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Samson and Delilah" },
                    { 297, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Samson and Delilah" },
                    { 298, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Samson and Delilah" },
                    { 299, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Samson and Delilah" },
                    { 300, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Samson and Delilah" },
                    { 301, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 302, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 303, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 304, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 305, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 306, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 307, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 308, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 309, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 310, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 311, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Man in Oriental Dress" },
                    { 312, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Man in Oriental Dress" },
                    { 313, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Man in Oriental Dress" },
                    { 314, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Man in Oriental Dress" },
                    { 315, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Man in Oriental Dress" },
                    { 316, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Man in Oriental Dress" },
                    { 317, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Man in Oriental Dress" },
                    { 318, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Man in Oriental Dress" },
                    { 319, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Man in Oriental Dress" },
                    { 320, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Man in Oriental Dress" },
                    { 321, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Holy Family at Night" },
                    { 322, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Holy Family at Night" },
                    { 323, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Holy Family at Night" },
                    { 324, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Holy Family at Night" },
                    { 325, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Holy Family at Night" },
                    { 326, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Holy Family at Night" },
                    { 327, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Holy Family at Night" },
                    { 328, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Holy Family at Night" },
                    { 329, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Holy Family at Night" },
                    { 330, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Holy Family at Night" },
                    { 331, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 332, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 333, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 334, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 335, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 336, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Conspiracy of the Batavians under Claudius Civilis" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 337, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 338, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 339, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 340, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 341, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 342, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 343, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 344, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 345, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 346, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 347, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 348, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 349, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 350, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 351, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Landscape with a Stone Bridge" },
                    { 352, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Landscape with a Stone Bridge" },
                    { 353, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Landscape with a Stone Bridge" },
                    { 354, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Landscape with a Stone Bridge" },
                    { 355, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Landscape with a Stone Bridge" },
                    { 356, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Landscape with a Stone Bridge" },
                    { 357, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Landscape with a Stone Bridge" },
                    { 358, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Landscape with a Stone Bridge" },
                    { 359, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Landscape with a Stone Bridge" },
                    { 360, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Landscape with a Stone Bridge" },
                    { 361, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Self Portrait as the Apostle Paul" },
                    { 362, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Self Portrait as the Apostle Paul" },
                    { 363, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Self Portrait as the Apostle Paul" },
                    { 364, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Self Portrait as the Apostle Paul" },
                    { 365, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Self Portrait as the Apostle Paul" },
                    { 366, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Self Portrait as the Apostle Paul" },
                    { 367, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Self Portrait as the Apostle Paul" },
                    { 368, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Self Portrait as the Apostle Paul" },
                    { 369, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Self Portrait as the Apostle Paul" },
                    { 370, "1661", "This is Rembrandt’s first and only self portrait in the guise of a biblical figure. The manuscript and the sword projecting from his cloak are Paul’s traditional attributes. Like the other apostles Rembrandt painted in the same period, Paul too is a real, everyday person. By using his own likeness here Rembrandt encourages a direct bond with the saint.", "SK-A-4050", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Self Portrait as the Apostle Paul" },
                    { 371, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 372, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 373, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 374, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 375, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 376, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 377, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 378, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 379, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 380, "c. 1665 - c. 1669", "Two contemporaries had themselves portrayed by Rembrandt in historicizing costumes as characters from the Bible. The couple’s tender embrace is at the centre of this poignant painting: the man’s loving gesture is returned with a gentle caress. The figures and their poses agree with the study (No 67), only the figure of King Abimelech spying on them is missing. We, the viewers, assume his role as witnesses of their clandestine love.", "SK-C-216", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Couple as Isaac and Rebecca, known as ‘The Jewish Bride’" },
                    { 381, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 382, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 383, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 384, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 385, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 386, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 387, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 388, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 389, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 390, "1642", null, "SK-C-5", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Militia Company of District II under the Command of Captain Frans Banninck Cocq, Known as the ‘Night Watch’" },
                    { 391, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Woman, Possibly Maria Trip" },
                    { 392, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Woman, Possibly Maria Trip" },
                    { 393, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Woman, Possibly Maria Trip" },
                    { 394, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Woman, Possibly Maria Trip" },
                    { 395, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Woman, Possibly Maria Trip" },
                    { 396, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Woman, Possibly Maria Trip" },
                    { 397, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Woman, Possibly Maria Trip" },
                    { 398, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Woman, Possibly Maria Trip" },
                    { 399, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Woman, Possibly Maria Trip" },
                    { 400, "1639", "The young sitter is assumed to be Maria Trip, the daughter of a wealthy Amsterdam merchant. She displays\nher wealth with pride. Her dress is trimmed with white linen so fine it is almost transparent. She sports a fortune in pearls, and in her left hand she casually holds the knobbed handle of a folding fan. In 1639 this\nwas still a rare and costly accessory.", "SK-C-597", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Woman, Possibly Maria Trip" },
                    { 401, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Self-portrait" },
                    { 402, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Self-portrait" },
                    { 403, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Self-portrait" },
                    { 404, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Self-portrait" },
                    { 405, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Self-portrait" },
                    { 406, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Self-portrait" },
                    { 407, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Self-portrait" },
                    { 408, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Self-portrait" },
                    { 409, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Self-portrait" },
                    { 410, "c. 1628", "Even as an inexperienced young artist, Rembrandt did not shy away from experimenting. Here the light\nglances along his right cheek, while the rest of his face is veiled in shadow. It takes a while to realize that the\nartist is gazing intently out at us. Using the butt end of his brush, Rembrandt made scratches in the still wet\npaint to accentuate the curls of his tousled hair.", "SK-A-4691", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Self-portrait" },
                    { 411, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 412, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 413, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 414, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 415, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 416, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 417, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 418, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 419, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" },
                    { 420, "1662", "This is Rembrandt’s first and only corporate group portrait. The Syndics stands out for its exceptionally large format and more than life-sized figures. All eyes of the sampling officials – who assessed the quality of dyed cloth – are turned to us and one figure even rises from his chair as if to acknowledge our presence. Because of the low vantage point, the table seems to jut out of the picture.", "SK-C-6", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Sampling Officials of the Amsterdam Drapers’ Guild, known as ‘The Syndics’" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 421, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait de Marten Soolmans" },
                    { 422, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait de Marten Soolmans" },
                    { 423, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait de Marten Soolmans" },
                    { 424, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait de Marten Soolmans" },
                    { 425, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait de Marten Soolmans" },
                    { 426, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait de Marten Soolmans" },
                    { 427, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait de Marten Soolmans" },
                    { 428, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait de Marten Soolmans" },
                    { 429, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait de Marten Soolmans" },
                    { 430, "1634", "Marten était le fils d’un riche immigrant flamand, propriétaire d’une prospère raffinerie de sucre à Amsterdam. Plein d’assurance, il posa en 1634 pour Rembrandt qui était alors l’un des peintres portraitistes les plus sollicités d’Amsterdam. Les deux hommes s’étaient probablement rencontrés dans la ville de Leyde où Marten avait fait auparavant des études de droit. Son costume exubérant, garni de dentelle coûteuse et d’extravagantes rosettes à ses souliers, lui valurent au XIXe siècle le qualificatif de ‘dandy’.", "SK-A-5033", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait de Marten Soolmans" },
                    { 431, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of Oopjen Coppit" },
                    { 432, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of Oopjen Coppit" },
                    { 433, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of Oopjen Coppit" },
                    { 434, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of Oopjen Coppit" },
                    { 435, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of Oopjen Coppit" },
                    { 436, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of Oopjen Coppit" },
                    { 437, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of Oopjen Coppit" },
                    { 438, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of Oopjen Coppit" },
                    { 439, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of Oopjen Coppit" },
                    { 440, "1634", "In contrast to the newcomer Marten, Oopjen’s family had already been living in Amsterdam for generations. Her grandfather had made his fortune trading grain and gunpowder, and her father belonged to Amsterdam’s small group of powerful rulers. Even though Oopjen’s clothing is less modern than Marten’s, with her black silk gown and expensive jewellery she was certainly showing off her wealth.", "SK-C-1768", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of Oopjen Coppit" },
                    { 441, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Milkmaid" },
                    { 442, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Milkmaid" },
                    { 443, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Milkmaid" },
                    { 444, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Milkmaid" },
                    { 445, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Milkmaid" },
                    { 446, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Milkmaid" },
                    { 447, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Milkmaid" },
                    { 448, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Milkmaid" },
                    { 449, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Milkmaid" },
                    { 450, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Milkmaid" },
                    { 451, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Head of a Boy" },
                    { 452, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Head of a Boy" },
                    { 453, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Head of a Boy" },
                    { 454, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Head of a Boy" },
                    { 455, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Head of a Boy" },
                    { 456, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Head of a Boy" },
                    { 457, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Head of a Boy" },
                    { 458, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Head of a Boy" },
                    { 459, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Head of a Boy" },
                    { 460, "after 1643", null, "SK-A-2391", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Head of a Boy" },
                    { 461, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 462, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portret van Rembrandt Harmensz. van Rijn" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 463, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 464, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 465, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 466, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 467, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 468, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 469, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 470, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 471, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 472, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 473, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 474, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 475, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 476, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 477, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 478, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 479, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 480, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 481, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Young Woman in Fantasy Costume" },
                    { 482, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Young Woman in Fantasy Costume" },
                    { 483, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Young Woman in Fantasy Costume" },
                    { 484, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Young Woman in Fantasy Costume" },
                    { 485, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Young Woman in Fantasy Costume" },
                    { 486, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Young Woman in Fantasy Costume" },
                    { 487, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Young Woman in Fantasy Costume" },
                    { 488, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Young Woman in Fantasy Costume" },
                    { 489, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Young Woman in Fantasy Costume" },
                    { 490, "1633", "The young woman’s clothing is not in keeping with the fashions of Rembrandt’s day, but rather reflects styles of earlier centuries. The woman’s distinctive features – a domed forehead, slightly bulging eyes, and\npronounced chin – are easily recognized in depictions of ancient goddesses and heroines that Rembrandt\npainted in the 1630s. Thus the painting is not strictly a portrait, but a ‘tronie’, or fantasy head.", "SK-A-4057", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Young Woman in Fantasy Costume" },
                    { 491, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 492, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 493, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 494, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 495, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 496, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 497, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 498, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 499, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 500, "after c. 1634", null, "SK-A-358", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Man, perhaps Rembrandt's Father, Harmen Gerritsz van Rijn" },
                    { 501, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 502, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 503, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 504, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Rembrandt’s Son Titus in a Monk’s Habit" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 505, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 506, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 507, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 508, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 509, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 510, "1660", "Rembrandt’s son Titus was probably the model for this ‘portrait’ of a Franciscan monk. His downcast eyes lend him an air of quiet introspection. His serene, pale face stands out clearly against a backdrop of green and brown vegetation.Solitary retreat into nature for prayer and reflection was of great importance to Saint Francis and his order.", "SK-A-3138", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Rembrandt’s Son Titus in a Monk’s Habit" },
                    { 511, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 512, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 513, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 514, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 515, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 516, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 517, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 518, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 519, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 520, "1631", "Light comes in from behind the old woman: the vivid glow illuminates the book and her hand, so thickly painted that the wrinkles seem almost modelled in clay. Her face remains in shadow. The woman could be the biblical prophetess Hannah. According to the Gospel of Luke, she was an elderly widow who worshipped God night and day with fasting and prayer.", "SK-A-3066", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "An Old Woman Reading, Probably the Prophetess Hannah" },
                    { 521, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Bust of a Laughing Young Man" },
                    { 522, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Bust of a Laughing Young Man" },
                    { 523, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Bust of a Laughing Young Man" },
                    { 524, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Bust of a Laughing Young Man" },
                    { 525, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Bust of a Laughing Young Man" },
                    { 526, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Bust of a Laughing Young Man" },
                    { 527, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Bust of a Laughing Young Man" },
                    { 528, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Bust of a Laughing Young Man" },
                    { 529, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Bust of a Laughing Young Man" },
                    { 530, "c. 1629 - c. 1630", null, "SK-A-3934", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Bust of a Laughing Young Man" },
                    { 531, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Still Life with Peacocks" },
                    { 532, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Still Life with Peacocks" },
                    { 533, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Still Life with Peacocks" },
                    { 534, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Still Life with Peacocks" },
                    { 535, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Still Life with Peacocks" },
                    { 536, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Still Life with Peacocks" },
                    { 537, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Still Life with Peacocks" },
                    { 538, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Still Life with Peacocks" },
                    { 539, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Still Life with Peacocks" },
                    { 540, "c. 1639", "In Rembrandt’s time, peacocks were a delicacy for the well-to-do: the meat was used as filling for pasties. After being slaughtered, the birds were hung upside down to drain their blood, as Rembrandt has depicted\nin this pantry. He must have been fascinated by the plumage’s magnificent markings and dazzling colours:\nblue, green and yellow ochre.", "SK-A-3981", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Still Life with Peacocks" },
                    { 541, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Tobit and Anna with the Kid" },
                    { 542, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Tobit and Anna with the Kid" },
                    { 543, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Tobit and Anna with the Kid" },
                    { 544, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Tobit and Anna with the Kid" },
                    { 545, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Tobit and Anna with the Kid" },
                    { 546, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Tobit and Anna with the Kid" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 547, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Tobit and Anna with the Kid" },
                    { 548, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Tobit and Anna with the Kid" },
                    { 549, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Tobit and Anna with the Kid" },
                    { 550, "1626", "Tobit’s blindness has condemned him and his wife to a life of grinding poverty: his once expensive tabard is\ntorn and tattered. When Anna comes home with a kid, a reward for her hard work, Tobit thinks she has stolen\nit. In desperation, he prays God to grant him a quick death. Anna looks on in bewilderment.", "SK-A-4717", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Tobit and Anna with the Kid" },
                    { 551, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 552, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 553, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 554, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 555, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 556, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 557, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 558, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 559, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 560, "1645 - 1647", null, "SK-A-3982", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a Man, thought to be Dr. Ephraïm Bueno" },
                    { 561, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of Johannes Wtenbogaert" },
                    { 562, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of Johannes Wtenbogaert" },
                    { 563, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of Johannes Wtenbogaert" },
                    { 564, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of Johannes Wtenbogaert" },
                    { 565, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of Johannes Wtenbogaert" },
                    { 566, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of Johannes Wtenbogaert" },
                    { 567, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of Johannes Wtenbogaert" },
                    { 568, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of Johannes Wtenbogaert" },
                    { 569, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of Johannes Wtenbogaert" },
                    { 570, "1633", "The 76-year-old Remonstrant minister, once the court chaplain of Prince Maurice, wears a calotte (skullcap)\nand a ‘tabard’, a fur-lined cloak – the kind of clothing elderly scholars preferred to be portrayed in. Wtenbogaert’s face is more realistically modelled than his hands, which may have been done by a pupil in Rembrandt’s workshop.", "SK-A-4885", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of Johannes Wtenbogaert" },
                    { 571, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Musical Company" },
                    { 572, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Musical Company" },
                    { 573, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Musical Company" },
                    { 574, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Musical Company" },
                    { 575, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Musical Company" },
                    { 576, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Musical Company" },
                    { 577, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Musical Company" },
                    { 578, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Musical Company" },
                    { 579, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Musical Company" },
                    { 580, "1626", "This curious painting refuses to divulge its secrets. The image can be interpreted as an admonition to praise God with singing and music-making, but also as a risqué scene of seduction. The young woman’s gaudy garments and red shoes are in questionable taste, and the old woman looks suspiciously like a procuress. Perhaps the painting contains a warning against immoral conduct.", "SK-A-4674", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Musical Company" },
                    { 581, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 582, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 583, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 584, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 585, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 586, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 587, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 588, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Joseph Telling his Dreams to his Parents and Brothers" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 589, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 590, "1633", null, "SK-A-3477", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Joseph Telling his Dreams to his Parents and Brothers" },
                    { 591, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Denial of St Peter" },
                    { 592, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Denial of St Peter" },
                    { 593, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Denial of St Peter" },
                    { 594, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Denial of St Peter" },
                    { 595, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Denial of St Peter" },
                    { 596, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Denial of St Peter" },
                    { 597, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Denial of St Peter" },
                    { 598, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Denial of St Peter" },
                    { 599, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Denial of St Peter" },
                    { 600, "1660", "In this nocturnal scene lit by a candle, Peter is recognized by soldiers as a disciple of Christ. He denies this,\nhowever, renouncing his master. Christ, in the murky right background, looks back at Peter, as he is led away\nby soldiers. Rembrandt had pupils in his workshop until the very last years of his life. Technical investigations have revealed that he was assisted in this painting.", "SK-A-3137", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Denial of St Peter" },
                    { 601, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 602, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 603, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 604, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 605, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 606, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 607, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 608, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 609, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 610, "1634", "Haesje van Cleyburg, the wife of a wealthy Rotterdam beer brewer, is fashionably yet extremely soberly dressed. She has not been made more beautiful than she was: the wrinkles, shadows under her eyes, the\nbushy eyebrows, and the greying hair are all rendered with painstaking realism. What makes the portrait so charming is the faint smile that plays across her slightly parted lips.", "SK-A-4833", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of Haesje Jacobsdr van Cleyburg" },
                    { 611, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Samson and Delilah" },
                    { 612, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Samson and Delilah" },
                    { 613, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Samson and Delilah" },
                    { 614, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Samson and Delilah" },
                    { 615, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Samson and Delilah" },
                    { 616, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Samson and Delilah" },
                    { 617, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Samson and Delilah" },
                    { 618, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Samson and Delilah" },
                    { 619, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Samson and Delilah" },
                    { 620, "c. 1626 - c. 1630", "This scene represents the biblical story of the Israelite Samson and the Philistine Delilah. Delilah seduced Samson and lured him into revealing the secret of his superhuman strength, which he would lose if his hair were cut. Without his long hair he would be like any other mortal. Rembrandt painted Samson asleep on Delilah’s lap. She grasps Samson’s hair and signals the approaching man with scissors to be quiet.", "SK-A-4096", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Samson and Delilah" },
                    { 621, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 622, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 623, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 624, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 625, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 626, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 627, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 628, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 629, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Jeremiah Lamenting the Destruction of Jerusalem" },
                    { 630, "1630", "Downcast, the biblical prophet Jeremiah leans his tired head on his hand. He mourns the burning city of Jerusalem (left background), the destruction of which he had predicted. The most important part of the depiction – the figure of Jeremiah – is painted with great precision, while his surroundings are barely worked out. Rembrandt used powerful contrasts of light and shadow to heighten the drama of the scene.", "SK-A-3276", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Jeremiah Lamenting the Destruction of Jerusalem" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 631, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Man in Oriental Dress" },
                    { 632, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Man in Oriental Dress" },
                    { 633, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Man in Oriental Dress" },
                    { 634, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Man in Oriental Dress" },
                    { 635, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Man in Oriental Dress" },
                    { 636, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Man in Oriental Dress" },
                    { 637, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Man in Oriental Dress" },
                    { 638, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Man in Oriental Dress" },
                    { 639, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Man in Oriental Dress" },
                    { 640, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Man in Oriental Dress" },
                    { 641, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Holy Family at Night" },
                    { 642, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Holy Family at Night" },
                    { 643, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Holy Family at Night" },
                    { 644, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Holy Family at Night" },
                    { 645, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Holy Family at Night" },
                    { 646, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Holy Family at Night" },
                    { 647, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Holy Family at Night" },
                    { 648, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Holy Family at Night" },
                    { 649, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Holy Family at Night" },
                    { 650, "c. 1642 - c. 1648", null, "SK-A-4119", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Holy Family at Night" },
                    { 651, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 652, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 653, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 654, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 655, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 656, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 657, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 658, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 659, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 660, "1661 - 1662", "Resolved to overthrow Roman domination, the Batavians enter into a treaty in a nocturnal ritual. This rebellion took place in 69 AD and was led by the one-eyed Batavian chieftain Claudius Civilis, here portrayed centrally. Rembrandt depicts the moment when the Batavians swear their oath by striking their swords together and raising the beaker. The rough facture and powerful\ncontrast of light and dark are typical of Rembrandt’s (late) work.", "SK-C-1747", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Conspiracy of the Batavians under Claudius Civilis" },
                    { 661, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 662, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 663, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 664, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 665, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 666, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 667, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 668, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 669, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 670, "c. 1640 - c. 1645", null, "SK-A-91", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Salome ontvangt het hoofd van Johannes de Doper" },
                    { 671, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Landscape with a Stone Bridge" },
                    { 672, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Landscape with a Stone Bridge" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 673, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Landscape with a Stone Bridge" },
                    { 674, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Landscape with a Stone Bridge" },
                    { 675, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Landscape with a Stone Bridge" },
                    { 676, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Landscape with a Stone Bridge" },
                    { 677, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Landscape with a Stone Bridge" },
                    { 678, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Landscape with a Stone Bridge" },
                    { 679, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Landscape with a Stone Bridge" },
                    { 680, "c. 1638", "Rembrandt painted only a few landscapes, mostly imaginary mountain scenes. Although The Stone Bridge\nis composed of elements studied from reality, it probably does not represent a specific place. The painting’s\nmagical quality derives from its dramatic illumination: a beam of sunlight breaks through the clouds, making\nthe approaching storm seem twice as menacing.", "SK-A-1935", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Landscape with a Stone Bridge" },
                    { 681, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Love Letter" },
                    { 682, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Love Letter" },
                    { 683, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Love Letter" },
                    { 684, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Love Letter" },
                    { 685, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Love Letter" },
                    { 686, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Love Letter" },
                    { 687, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Love Letter" },
                    { 688, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Love Letter" },
                    { 689, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Love Letter" },
                    { 690, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Love Letter" },
                    { 691, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Landscape with a Farm" },
                    { 692, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Landscape with a Farm" },
                    { 693, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Landscape with a Farm" },
                    { 694, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Landscape with a Farm" },
                    { 695, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Landscape with a Farm" },
                    { 696, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Landscape with a Farm" },
                    { 697, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Landscape with a Farm" },
                    { 698, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Landscape with a Farm" },
                    { 699, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Landscape with a Farm" },
                    { 700, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Landscape with a Farm" },
                    { 701, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The raising of Lazarus" },
                    { 702, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The raising of Lazarus" },
                    { 703, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The raising of Lazarus" },
                    { 704, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The raising of Lazarus" },
                    { 705, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The raising of Lazarus" },
                    { 706, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The raising of Lazarus" },
                    { 707, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The raising of Lazarus" },
                    { 708, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The raising of Lazarus" },
                    { 709, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The raising of Lazarus" },
                    { 710, "1620 - 1650", null, "SK-A-4019", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The raising of Lazarus" },
                    { 711, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Woman Reading a Letter" },
                    { 712, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Woman Reading a Letter" },
                    { 713, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Woman Reading a Letter" },
                    { 714, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Woman Reading a Letter" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 715, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Woman Reading a Letter" },
                    { 716, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Woman Reading a Letter" },
                    { 717, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Woman Reading a Letter" },
                    { 718, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Woman Reading a Letter" },
                    { 719, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Woman Reading a Letter" },
                    { 720, "c. 1663", "Enjoying a quiet, private moment, this young woman is absorbed in reading a letter in the morning light. She is still wearing her blue night jacket. All of the colours in the composition are secondary to its radiant lapis lazuli blue. Vermeer recorded the effects of light with extraordinary precision. Particularly innovative is his rendering of the woman’s skin with pale grey, and the shadows on the wall using light blue.", "SK-C-251", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Woman Reading a Letter" },
                    { 721, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Milkmaid" },
                    { 722, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Milkmaid" },
                    { 723, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Milkmaid" },
                    { 724, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Milkmaid" },
                    { 725, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Milkmaid" },
                    { 726, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Milkmaid" },
                    { 727, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Milkmaid" },
                    { 728, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Milkmaid" },
                    { 729, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Milkmaid" },
                    { 730, "c. 1660", "A maidservant pours milk, entirely absorbed in her work. Except for the stream of milk, everything else is still. Vermeer took this simple everyday activity and made it the subject of an impressive painting – the woman stands like a statue in the brightly lit room. Vermeer also had an eye for how light by means of hundreds of colourful dots plays over the surface of objects.", "SK-A-2344", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Milkmaid" },
                    { 731, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "The Love Letter" },
                    { 732, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "The Love Letter" },
                    { 733, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "The Love Letter" },
                    { 734, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "The Love Letter" },
                    { 735, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "The Love Letter" },
                    { 736, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "The Love Letter" },
                    { 737, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "The Love Letter" },
                    { 738, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "The Love Letter" },
                    { 739, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "The Love Letter" },
                    { 740, "c. 1669 - c. 1670", "Vermeer chose an unusual vantage point for this painting. From a dim space in the foreground, a glimpse is afforded of another room with a domestic scene. An elegantly dressed woman looks up expectantly at a maidservant, who has just handed her a letter. The seascape on the wall behind them may well allude to the epistle’s subject: during the 17th century, the sea was often compared to love, and the lover to a ship.", "SK-A-1595", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "The Love Letter" },
                    { 741, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "View of Houses in Delft, Known as The Little Street" },
                    { 742, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "View of Houses in Delft, Known as The Little Street" },
                    { 743, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "View of Houses in Delft, Known as The Little Street" },
                    { 744, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "View of Houses in Delft, Known as The Little Street" },
                    { 745, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "View of Houses in Delft, Known as The Little Street" },
                    { 746, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "View of Houses in Delft, Known as The Little Street" },
                    { 747, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "View of Houses in Delft, Known as The Little Street" },
                    { 748, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "View of Houses in Delft, Known as The Little Street" },
                    { 749, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "View of Houses in Delft, Known as The Little Street" },
                    { 750, "c. 1658", "This is an unusual painting in Vermeer’s oeuvre, and remarkable for its time as a portrait of ordinary houses. The composition is as exciting as it is balanced. The old walls with their bricks, whitewash, and cracks are almost tangible. The location is Vlamingstraat 40–42 in Delft. Vermeer’s\naunt Ariaentgen Claes lived in the house at the right, with her children, from around 1645 until her death in 1670.", "SK-A-2860", "Johannes Vermeer", new DateTime(1632, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1675, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "View of Houses in Delft, Known as The Little Street" },
                    { 751, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Landscape with a Farm" },
                    { 752, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Landscape with a Farm" },
                    { 753, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Landscape with a Farm" },
                    { 754, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Landscape with a Farm" },
                    { 755, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Landscape with a Farm" },
                    { 756, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Landscape with a Farm" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 757, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Landscape with a Farm" },
                    { 758, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Landscape with a Farm" },
                    { 759, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Landscape with a Farm" },
                    { 760, "1648", null, "SK-A-2351", "Jan Vermeer van Haarlem (I)", new DateTime(1628, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1691, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Landscape with a Farm" },
                    { 761, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 762, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 763, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 764, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 765, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 766, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 767, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 768, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 769, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 770, "1730 - 1774", null, "SK-A-3298", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portrait of a man, perhaps Rembrandt's father, Harmen Gerritsz van Rijn" },
                    { 771, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Man in Oriental Dress" },
                    { 772, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Man in Oriental Dress" },
                    { 773, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Man in Oriental Dress" },
                    { 774, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Man in Oriental Dress" },
                    { 775, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Man in Oriental Dress" },
                    { 776, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Man in Oriental Dress" },
                    { 777, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Man in Oriental Dress" },
                    { 778, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Man in Oriental Dress" },
                    { 779, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Man in Oriental Dress" },
                    { 780, "1635", "Rembrandt manipulated light in a highly personal way. Here, the man’s turban and the right side of his face are brilliantly illuminated, while the left side is in shadow. Exotic character heads like this – they are not portraits – were extremely popular in the 17th century; early on, they were widely copied and imitated. They\nwere known as ‘Turkish tronies’.", "SK-A-3340", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Man in Oriental Dress" },
                    { 781, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 89.99m, "48\" x 36\"", "Farming Village at Twilight" },
                    { 782, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 59.99m, "32\" x 24\"", "Farming Village at Twilight" },
                    { 783, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Poster", 29.99m, "24\" x 18\"", "Farming Village at Twilight" },
                    { 784, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "Mug", 19.99m, "12oz", "Farming Village at Twilight" },
                    { 785, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Small", "Farming Village at Twilight" },
                    { 786, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Medium", "Farming Village at Twilight" },
                    { 787, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "Large", "Farming Village at Twilight" },
                    { 788, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 29.99m, "XL", "Farming Village at Twilight" },
                    { 789, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "2XL", "Farming Village at Twilight" },
                    { 790, "1884", null, "SK-A-3307", "Vincent van Gogh", new DateTime(1853, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nederlands", "T-Shirt", 34.99m, "3XL", "Farming Village at Twilight" },
                    { 791, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 89.99m, "48\" x 36\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 792, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 59.99m, "32\" x 24\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 793, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Poster", 29.99m, "24\" x 18\"", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 794, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "Mug", 19.99m, "12oz", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 795, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Small", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 796, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Medium", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 797, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "Large", "Portret van Rembrandt Harmensz. van Rijn" },
                    { 798, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 29.99m, "XL", "Portret van Rembrandt Harmensz. van Rijn" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[] { 799, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "2XL", "Portret van Rembrandt Harmensz. van Rijn" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[] { 800, "1640 - 1800", null, "SK-A-3341", "Rembrandt Harmensz. van Rijn", new DateTime(1606, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1669, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noord-Nederlands", "T-Shirt", 34.99m, "3XL", "Portret van Rembrandt Harmensz. van Rijn" });
        }

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.AlterColumn<string>(
                name: "ArtDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
