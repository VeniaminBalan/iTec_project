using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTec_project.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Profile_id",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    User_id = table.Column<string>(type: "text", nullable: true),
                    DateStarted = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    WorkExperience = table.Column<int[]>(type: "integer[]", nullable: false),
                    IndustriesWorkExperience = table.Column<int[]>(type: "integer[]", nullable: false),
                    OtherOption = table.Column<string>(type: "text", nullable: false),
                    DevPost = table.Column<int>(type: "integer", nullable: false),
                    BackendFramework = table.Column<int[]>(type: "integer[]", nullable: false),
                    OtherBackendFrameworkOption = table.Column<string>(type: "text", nullable: false),
                    ProgramingLanguages = table.Column<int>(type: "integer", nullable: false),
                    BackendFrameworkTools = table.Column<int[]>(type: "integer[]", nullable: false),
                    FrontendFramework = table.Column<int[]>(type: "integer[]", nullable: false),
                    OtherFrontendFrameworkOption = table.Column<string>(type: "text", nullable: false),
                    FrameworkExperience = table.Column<int[]>(type: "integer[]", nullable: false),
                    FrontendFrameworkTools = table.Column<int[]>(type: "integer[]", nullable: false),
                    ComunicationStyle = table.Column<int>(type: "integer", nullable: false),
                    OtherComunicationStyle = table.Column<string>(type: "text", nullable: false),
                    ConflictsHandle = table.Column<int>(type: "integer", nullable: false),
                    OtherConflictsHandle = table.Column<string>(type: "text", nullable: false),
                    CommunicationSkillsRating = table.Column<int[]>(type: "integer[]", nullable: false),
                    TeamWorkAbilityRate = table.Column<int[]>(type: "integer[]", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Profile_id",
                table: "Users",
                column: "Profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_User_id",
                table: "Profiles",
                column: "User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profiles_Profile_id",
                table: "Users",
                column: "Profile_id",
                principalTable: "Profiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profiles_Profile_id",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Users_Profile_id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Profile_id",
                table: "Users");
        }
    }
}
