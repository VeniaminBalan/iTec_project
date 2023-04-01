using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTec_project.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_User_id",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "Profiles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_User_id",
                table: "Profiles",
                newName: "IX_Profiles_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Profiles",
                newName: "User_id");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                newName: "IX_Profiles_User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_User_id",
                table: "Profiles",
                column: "User_id",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
