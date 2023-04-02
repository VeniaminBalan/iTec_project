using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTec_project.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    QuickInfo = table.Column<string>(type: "text", nullable: false),
                    Salt = table.Column<string>(type: "text", nullable: false),
                    Hashed = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    DateStarted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    WorkExperience = table.Column<int[]>(type: "integer[]", nullable: true),
                    IndustriesWorkExperience = table.Column<int[]>(type: "integer[]", nullable: true),
                    OtherOption = table.Column<string>(type: "text", nullable: true),
                    DevPost = table.Column<int>(type: "integer", nullable: true),
                    BackendFramework = table.Column<int[]>(type: "integer[]", nullable: true),
                    OtherBackendFrameworkOption = table.Column<string>(type: "text", nullable: true),
                    ProgramingLanguages = table.Column<int>(type: "integer", nullable: true),
                    BackendFrameworkTools = table.Column<int[]>(type: "integer[]", nullable: true),
                    FrontendFramework = table.Column<int[]>(type: "integer[]", nullable: true),
                    OtherFrontendFrameworkOption = table.Column<string>(type: "text", nullable: true),
                    FrameworkExperience = table.Column<int[]>(type: "integer[]", nullable: true),
                    FrontendFrameworkTools = table.Column<int[]>(type: "integer[]", nullable: true),
                    ComunicationStyle = table.Column<int>(type: "integer", nullable: true),
                    OtherComunicationStyle = table.Column<string>(type: "text", nullable: true),
                    ConflictsHandle = table.Column<int>(type: "integer", nullable: true),
                    OtherConflictsHandle = table.Column<string>(type: "text", nullable: true),
                    CommunicationSkillsRating = table.Column<int[]>(type: "integer[]", nullable: true),
                    TeamWorkAbilityRate = table.Column<int[]>(type: "integer[]", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
