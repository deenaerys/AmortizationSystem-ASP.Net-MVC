using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amortization_System.Migrations
{
    /// <inheritdoc />
    public partial class replaceguid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    buyer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    project_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loan_amount = table.Column<double>(type: "float", nullable: false),
                    payment_start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    condo_unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_term = table.Column<int>(type: "int", nullable: false),
                    interest_rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyers");
        }
    }
}
