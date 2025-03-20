using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_4.Migrations
{
    /// <inheritdoc />
    public partial class configurationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KitapAdi",
                table: "Kitaplar",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KapakResmi",
                table: "Kitaplar",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValue: "bos.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fiyat",
                table: "Kitaplar",
                type: "money",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KitapAdi",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "KapakResmi",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValue: "bos.jpg");

            migrationBuilder.AlterColumn<double>(
                name: "Fiyat",
                table: "Kitaplar",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
