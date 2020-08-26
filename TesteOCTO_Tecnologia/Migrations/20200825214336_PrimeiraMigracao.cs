using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteOCTO_Tecnologia.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DTNascimento = table.Column<DateTime>(nullable: false),
                    CPF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoEndereco = table.Column<byte>(nullable: false),
                    CEP = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    PessoaFisicaID = table.Column<int>(nullable: true),
                    PessoaJuridicaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Endereco_PessoaFisica_PessoaFisicaID",
                        column: x => x.PessoaFisicaID,
                        principalTable: "PessoaFisica",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endereco_PessoaJuridica_PessoaJuridicaID",
                        column: x => x.PessoaJuridicaID,
                        principalTable: "PessoaJuridica",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoTelefone = table.Column<byte>(nullable: false),
                    DDD = table.Column<int>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    PessoaFisicaID = table.Column<int>(nullable: true),
                    PessoaJuridicaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Telefone_PessoaFisica_PessoaFisicaID",
                        column: x => x.PessoaFisicaID,
                        principalTable: "PessoaFisica",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefone_PessoaJuridica_PessoaJuridicaID",
                        column: x => x.PessoaJuridicaID,
                        principalTable: "PessoaJuridica",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PessoaFisicaID",
                table: "Endereco",
                column: "PessoaFisicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PessoaJuridicaID",
                table: "Endereco",
                column: "PessoaJuridicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaFisicaID",
                table: "Telefone",
                column: "PessoaFisicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaJuridicaID",
                table: "Telefone",
                column: "PessoaJuridicaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");
        }
    }
}
