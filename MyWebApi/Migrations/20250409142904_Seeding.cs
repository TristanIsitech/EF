using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Capacity", "City", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("10306fb9-0da9-44d4-9501-72aee3f6c215"), "101 Rue des Arts", 800, "Bordeaux", "France", "Théâtre Royal" },
                    { new Guid("8388ff8f-e3e5-40df-bf0f-11b492adf401"), "789 Rue des Loisirs", 300, "Marseille", "France", "Salle Polyvalente" },
                    { new Guid("c63c2ea5-e595-4117-9b31-6cfe25352cfc"), "123 Rue des Événements", 500, "Paris", "France", "Centre des Congrès" },
                    { new Guid("de717324-48d7-4378-8289-cc549af91f98"), "202 Avenue des Foires", 10000, "Toulouse", "France", "Parc des Expositions" },
                    { new Guid("ee6da3af-5665-4fd1-af42-99b4d36b18c5"), "456 Avenue des Sports", 20000, "Lyon", "France", "Stade National" }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Company", "Email", "FirstName", "JobTitle", "LastName" },
                values: new object[,]
                {
                    { new Guid("75e908b5-745a-4c1f-8044-62084e3acb8e"), "CharityOrg", "eve.lemoine@example.com", "Eve", "Organisatrice", "Lemoine" },
                    { new Guid("cb0ff6db-1f86-4962-8d79-2973e2a36936"), "ArtExpo", "charlie.durand@example.com", "Charlie", "Curateur", "Durand" },
                    { new Guid("f3a42b35-1e96-44a8-942a-3b65b7c5eb0c"), "CodeAcademy", "diane.moreau@example.com", "Diane", "Formatrice", "Moreau" },
                    { new Guid("f4afa46d-a8b1-494b-bc6b-366107dce7c3"), "TechCorp", "alice.dupont@example.com", "Alice", "Développeuse", "Dupont" },
                    { new Guid("f601e270-2dde-4f5c-9e2c-44bcff3a2bfc"), "MusicWorld", "bob.martin@example.com", "Bob", "Producteur", "Martin" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Category", "Description", "EndDate", "LocationId", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("25181606-8e58-4887-8bd9-48b8ce366488"), 2, "Une conférence sur les dernières technologies.", new DateTime(2025, 4, 21, 14, 29, 3, 734, DateTimeKind.Utc).AddTicks(8836), new Guid("c63c2ea5-e595-4117-9b31-6cfe25352cfc"), new DateTime(2025, 4, 19, 14, 29, 3, 734, DateTimeKind.Utc).AddTicks(8488), 3, "Conférence Tech 2024" },
                    { new Guid("39477d27-ecf5-46fd-a55f-01ada64791dc"), 1, "Un festival avec des artistes internationaux.", new DateTime(2025, 5, 1, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(166), new Guid("ee6da3af-5665-4fd1-af42-99b4d36b18c5"), new DateTime(2025, 4, 29, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(164), 1, "Festival de Musique" },
                    { new Guid("50a75421-bc08-40ab-be9f-62de815a940a"), 6, "Un atelier pour apprendre les bases de la programmation.", new DateTime(2025, 5, 10, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(188), new Guid("10306fb9-0da9-44d4-9501-72aee3f6c215"), new DateTime(2025, 5, 9, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(187), 5, "Atelier de Programmation" },
                    { new Guid("7b5122d3-ff71-4875-b7df-b2becaf69912"), 3, "Une exposition mettant en avant des artistes contemporains.", new DateTime(2025, 4, 24, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(185), new Guid("8388ff8f-e3e5-40df-bf0f-11b492adf401"), new DateTime(2025, 4, 14, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(184), 4, "Exposition d'Art Moderne" },
                    { new Guid("89f792fd-5ff2-42b6-a227-e9eacc55f3d2"), 8, "Un gala pour collecter des fonds pour une bonne cause.", new DateTime(2025, 5, 20, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(191), new Guid("de717324-48d7-4378-8289-cc549af91f98"), new DateTime(2025, 5, 19, 14, 29, 3, 735, DateTimeKind.Utc).AddTicks(190), 0, "Gala de Charité" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("25181606-8e58-4887-8bd9-48b8ce366488"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("39477d27-ecf5-46fd-a55f-01ada64791dc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("50a75421-bc08-40ab-be9f-62de815a940a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7b5122d3-ff71-4875-b7df-b2becaf69912"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("89f792fd-5ff2-42b6-a227-e9eacc55f3d2"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("75e908b5-745a-4c1f-8044-62084e3acb8e"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("cb0ff6db-1f86-4962-8d79-2973e2a36936"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("f3a42b35-1e96-44a8-942a-3b65b7c5eb0c"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("f4afa46d-a8b1-494b-bc6b-366107dce7c3"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("f601e270-2dde-4f5c-9e2c-44bcff3a2bfc"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("10306fb9-0da9-44d4-9501-72aee3f6c215"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("8388ff8f-e3e5-40df-bf0f-11b492adf401"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c63c2ea5-e595-4117-9b31-6cfe25352cfc"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("de717324-48d7-4378-8289-cc549af91f98"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ee6da3af-5665-4fd1-af42-99b4d36b18c5"));
        }
    }
}
