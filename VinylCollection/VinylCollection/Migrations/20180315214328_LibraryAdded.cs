using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VinylCollection.Migrations
{
    public partial class LibraryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Library",
                columns: table => new
                {
                    CollectorID = table.Column<Guid>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Library", x => x.CollectorID);
                });

            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    CollectorID = table.Column<Guid>(nullable: false),
                    LibraryCollectorID = table.Column<Guid>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.CollectorID);
                    table.ForeignKey(
                        name: "FK_Record_Library_LibraryCollectorID",
                        column: x => x.LibraryCollectorID,
                        principalTable: "Library",
                        principalColumn: "CollectorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Record_LibraryCollectorID",
                table: "Record",
                column: "LibraryCollectorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.DropTable(
                name: "Library");
        }
    }
}
