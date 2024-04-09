using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudiantesApp.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Parcial1 = table.Column<float>(type: "real", nullable: false),
                    Parcial2 = table.Column<float>(type: "real", nullable: false),
                    Parcial3 = table.Column<float>(type: "real", nullable: false),
                    Final = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
