using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UrbanJunction.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Topics",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Agents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "61da24bb-a0c0-45c8-9b99-f12636ae5a6f", "guest@mail.com", false, false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAIAAYagAAAAEAwlx1rQqEwrcCcYlZDKZdOAmuVIFbevUzO7DRUXq7QeA1GOxBNKRsKqw3NslPBrzQ==", null, false, "2f267012-fdb2-42d0-a732-7a3b3e784fa4", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "ce29724b-d7ae-4dea-9ec5-946c3b9ea8d5", "agent@mail.com", false, false, null, "AGENT@MAIL.COM", "AGENT@MAIL.COM", "AQAAAAIAAYagAAAAEE0g/+gcin3IEvNmElqjVmnR+/KVl2wm2pj5x3vlY0zZrHlpKIgAgiHZV3suzhuocA==", null, false, "db64867f-020c-4830-9394-e9f07ce08459", false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Cottage" },
                    { 2, false, "Single-Family" },
                    { 3, false, "Duplex" }
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "IsDeleted", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("44a41a1c-943b-47e2-80e6-47463b6f139b"), false, "+359888888888", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "IsDeleted", "PricePerMonth", "RenterId", "Title" },
                values: new object[,]
                {
                    { 1, "North London, UK (near the border", new Guid("44a41a1c-943b-47e2-80e6-47463b6f139b"), 3, "A big topic for your whole family. Don't miss to buy a topic with three bedrooms.", "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", false, 2100.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "Big Topic Marina" },
                    { 2, "Near the Sea Garden in Burgas, Bulgaria", new Guid("44a41a1c-943b-47e2-80e6-47463b6f139b"), 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1", false, 1200.00m, null, "Family Topic Comfort" },
                    { 3, "Boyana Neighbourhood, Sofia, Bulgaria", new Guid("44a41a1c-943b-47e2-80e6-47463b6f139b"), 2, "This luxurious topic is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", false, 2000.00m, null, "Grand Topic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: new Guid("44a41a1c-943b-47e2-80e6-47463b6f139b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Agents");
        }
    }
}
