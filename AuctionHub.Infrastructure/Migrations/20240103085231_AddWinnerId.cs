using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddWinnerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lots_AspNetUsers_UserId",
                table: "Lots");

            migrationBuilder.DropIndex(
                name: "IX_Lots_UserId",
                table: "Lots");

            migrationBuilder.AddColumn<Guid>(
                name: "WinnerId",
                table: "Lots",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Lots_WinnerId",
                table: "Lots",
                column: "WinnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_AspNetUsers_WinnerId",
                table: "Lots",
                column: "WinnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lots_AspNetUsers_WinnerId",
                table: "Lots");

            migrationBuilder.DropIndex(
                name: "IX_Lots_WinnerId",
                table: "Lots");

            migrationBuilder.DropColumn(
                name: "WinnerId",
                table: "Lots");

            migrationBuilder.CreateIndex(
                name: "IX_Lots_UserId",
                table: "Lots",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_AspNetUsers_UserId",
                table: "Lots",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
