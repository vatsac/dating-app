using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class ExtendingApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Gender = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    KnownAs = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastActive = table.Column<DateTime>(type: "datetime", nullable: true),
                    Introduction = table.Column<string>(unicode: false, nullable: true),
                    LookingFor = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    Interests = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    Country = table.Column<string>(unicode: false, maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(unicode: false, nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsMain = table.Column<bool>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_UserId",
                table: "Photo",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
