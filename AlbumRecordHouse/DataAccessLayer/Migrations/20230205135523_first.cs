using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlbümBilgileri",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbümAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanatçıveyaGrup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ÇıkışTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    İndirimOranı = table.Column<int>(type: "int", nullable: false),
                    SatisiVarMi = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbümBilgileri", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Yöneticiler",
                columns: table => new
                {
                    YöneticiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıAdı = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yöneticiler", x => x.YöneticiId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yöneticiler_KullanıcıAdı",
                table: "Yöneticiler",
                column: "KullanıcıAdı",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbümBilgileri");

            migrationBuilder.DropTable(
                name: "Yöneticiler");
        }
    }
}
