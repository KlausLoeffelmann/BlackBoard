using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackBoard.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIdentityExternal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeLastEdited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    EntryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RevisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RevisionNo = table.Column<int>(type: "int", nullable: false),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: false),
                    PostingTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryScope = table.Column<int>(type: "int", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeLastEdited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.EntryId);
                    table.ForeignKey(
                        name: "FK_Entries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LogEntries",
                columns: table => new
                {
                    LogEntryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LogTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LogInfo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntries", x => x.LogEntryId);
                    table.ForeignKey(
                        name: "FK_LogEntries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WebLinks",
                columns: table => new
                {
                    WebLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeblinkScope = table.Column<int>(type: "int", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeLastEdited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebLinks", x => x.WebLinkId);
                    table.ForeignKey(
                        name: "FK_WebLinks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entries_UserId",
                table: "Entries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LogEntries_UserId",
                table: "LogEntries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WebLinks_UserId",
                table: "WebLinks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "LogEntries");

            migrationBuilder.DropTable(
                name: "WebLinks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
