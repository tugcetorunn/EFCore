using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_4.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevleri",
                columns: table => new
                {
                    YayineviId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayineviAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevleri", x => x.YayineviId);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    YazarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    YazarSoyadi = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.YazarId);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SayfaSayisi = table.Column<short>(type: "smallint", nullable: true),
                    BasimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BaskiSayisi = table.Column<short>(type: "smallint", nullable: false),
                    Ozet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KapakResmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KagitCinsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YayineviId = table.Column<int>(type: "int", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapId);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId");
                    table.ForeignKey(
                        name: "FK_Kitaplar_Yayinevleri_YayineviId",
                        column: x => x.YayineviId,
                        principalTable: "Yayinevleri",
                        principalColumn: "YayineviId");
                });

            migrationBuilder.CreateTable(
                name: "KitapYazarlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazarlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KitapYazarlar_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazarlar_Yazarlar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kodlar",
                columns: table => new
                {
                    KodId = table.Column<int>(type: "int", nullable: false),
                    BarkodYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KarekodYolu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kodlar", x => x.KodId);
                    table.ForeignKey(
                        name: "FK_Kodlar_Kitaplar_KodId",
                        column: x => x.KodId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YayineviId",
                table: "Kitaplar",
                column: "YayineviId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazarlar_KitapId",
                table: "KitapYazarlar",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazarlar_YazarId",
                table: "KitapYazarlar",
                column: "YazarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapYazarlar");

            migrationBuilder.DropTable(
                name: "Kodlar");

            migrationBuilder.DropTable(
                name: "Yazarlar");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Yayinevleri");
        }
    }
}
