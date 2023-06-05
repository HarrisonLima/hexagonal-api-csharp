using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Umfg.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class Migration_1_0_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false),
                    DS_PRODUTO = table.Column<string>(type: "longtext", nullable: false),
                    CD_BARRA = table.Column<string>(type: "longtext", nullable: false),
                    VL_PRODUTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
