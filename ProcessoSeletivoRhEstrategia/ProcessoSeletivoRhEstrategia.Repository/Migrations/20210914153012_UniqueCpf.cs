using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessoSeletivoRhEstrategia.Repository.Migrations
{
    public partial class UniqueCpf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Pessoa",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Cpf",
                table: "Pessoa",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Email",
                table: "Pessoa",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pessoa_Cpf",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_Email",
                table: "Pessoa");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Pessoa",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);
        }
    }
}
