using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmNetCoreUygulaması.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FilmTürü = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ımbd = table.Column<int>(type: "int", nullable: false),
                    VizyonTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmNo);
                });

            migrationBuilder.CreateTable(
                name: "Oyuncus",
                columns: table => new
                {
                    OyuncuNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyuncuAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OyuncuSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OyuncuYas = table.Column<int>(type: "int", nullable: false),
                    OynadigiFilmSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncus", x => x.OyuncuNo);
                });

            migrationBuilder.CreateTable(
                name: "Seyircis",
                columns: table => new
                {
                    SeyirciNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeyirciAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeyirciSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seyircis", x => x.SeyirciNo);
                });

            migrationBuilder.CreateTable(
                name: "Yönetmens",
                columns: table => new
                {
                    YönetmenNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YönetmenAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    YönetmenSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    FilmSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yönetmens", x => x.YönetmenNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Oyuncus");

            migrationBuilder.DropTable(
                name: "Seyircis");

            migrationBuilder.DropTable(
                name: "Yönetmens");
        }
    }
}
