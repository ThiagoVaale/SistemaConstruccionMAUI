using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Telephone = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 120, nullable: true),
                    CheckSetDeadlineId = table.Column<int>(type: "INTEGER", nullable: false),
                    IncludesVATDefault = table.Column<bool>(type: "INTEGER", nullable: false),
                    FreightIncludedDefault = table.Column<bool>(type: "INTEGER", nullable: false),
                    UsualFreightCost = table.Column<decimal>(type: "TEXT", precision: 18, scale: 2, nullable: true),
                    PaymentTermsText = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    Observations = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
