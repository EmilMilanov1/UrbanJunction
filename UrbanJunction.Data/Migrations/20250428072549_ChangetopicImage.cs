using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrbanJunction.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeHouseImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEEbD7gWkArLr0igj7i58amIlmr1rJrwb6LIJJi8ET9THYv4ZDyj+TuQ/9R1bxIAmeQ==", "b5a9a400-e1af-449e-82b6-10fab3c0d911" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEEUS9/kGCUNoc44BrKYL65JzJW/pobVI/GR2I208kBOVZWtZ3tRNyLsbCOxKJyyCaw==", "fdc81065-eca2-4dfc-b67f-ec58939486e1" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.rocketmortgage.com/resources-cmsassets/RocketMortgage.com/Article_Images/Large_Images/TypesOfHomes/types-of-homes-hero.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAELe209MEvAZFZw3IctmCxIV1dLkCTxNjOl4EslcqgWEiK4TFPpHd2XZCmhHV/CGwDA==", "a4dd849d-248e-4cde-bc41-f6b8eb5e70c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEPKDriUIm7Y4EHv1JHeVnhNYvBdLBIpHHFQR6ii5WSDorNfTnnHCMOChVfDlFFSARA==", "267d69e4-03a5-4d14-8849-02763b48bcb4" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg");
        }
    }
}
