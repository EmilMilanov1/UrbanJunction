using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrbanJunction.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEAwlx1rQqEwrcCcYlZDKZdOAmuVIFbevUzO7DRUXq7QeA1GOxBNKRsKqw3NslPBrzQ==", "2f267012-fdb2-42d0-a732-7a3b3e784fa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEE0g/+gcin3IEvNmElqjVmnR+/KVl2wm2pj5x3vlY0zZrHlpKIgAgiHZV3suzhuocA==", "db64867f-020c-4830-9394-e9f07ce08459" });
        }
    }
}
