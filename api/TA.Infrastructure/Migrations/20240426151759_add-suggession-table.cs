using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TA.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addsuggessiontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suggession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripDestination = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PlaceToVisit = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AccomodationSuggession = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TravelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dining = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AverageMoneySpent = table.Column<double>(type: "float", maxLength: 250, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggession", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suggession_CreatedBy",
                table: "Suggession",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Suggession_UpdatedBy",
                table: "Suggession",
                column: "UpdatedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suggession");
        }
    }
}
