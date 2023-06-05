using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Umfg.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false),
                    NR_DOCUMENTO = table.Column<string>(type: "longtext", nullable: false),
                    NM_CLIENTE = table.Column<string>(type: "longtext", nullable: false),
                    NR_CELULAR = table.Column<string>(type: "longtext", nullable: false),
                    DS_ENDERECO = table.Column<string>(type: "longtext", nullable: false),
                    DS_EMAIL = table.Column<string>(type: "longtext", nullable: false),
                    DS_OBSERVACAO = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
