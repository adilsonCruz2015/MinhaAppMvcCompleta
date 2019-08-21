using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Data.Migrations
{
    public partial class Ajuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Fornecedores_FormecedorId",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "FormecedorId",
                table: "Enderecos",
                newName: "FornecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_FormecedorId",
                table: "Enderecos",
                newName: "IX_Enderecos_FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Fornecedores_FornecedorId",
                table: "Enderecos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Fornecedores_FornecedorId",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "FornecedorId",
                table: "Enderecos",
                newName: "FormecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_FornecedorId",
                table: "Enderecos",
                newName: "IX_Enderecos_FormecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Fornecedores_FormecedorId",
                table: "Enderecos",
                column: "FormecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
