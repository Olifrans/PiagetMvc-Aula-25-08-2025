using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiagetMvc.Migrations
{
    /// <inheritdoc />
    public partial class NewAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Notas",
                table: "Aluno",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "Notas",
                table: "Aluno");
        }
    }
}
