using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa23FinalProjectGroup14.Migrations
{
    /// <inheritdoc />
    public partial class removemoviefromtransdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_Movies_MovieID",
                table: "TransactionDetails");

            migrationBuilder.DropIndex(
                name: "IX_TransactionDetails_MovieID",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "TransactionDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "TransactionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_MovieID",
                table: "TransactionDetails",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_Movies_MovieID",
                table: "TransactionDetails",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
