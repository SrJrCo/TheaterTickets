using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa23FinalProjectGroup14.Migrations
{
    /// <inheritdoc />
    public partial class seatsavail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Seat",
                table: "TransactionDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Theater",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seat",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "Theater",
                table: "Schedules");
        }
    }
}
