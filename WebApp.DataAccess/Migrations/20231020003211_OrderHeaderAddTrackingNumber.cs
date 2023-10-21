using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class OrderHeaderAddTrackingNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentIntenId",
                table: "OrderHeaders",
                newName: "TrackingNumber");

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "OrderHeaders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "OrderHeaders");

            migrationBuilder.RenameColumn(
                name: "TrackingNumber",
                table: "OrderHeaders",
                newName: "PaymentIntenId");
        }
    }
}
