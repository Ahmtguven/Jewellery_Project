using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApiJewelleryProject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bilekliklers",
                columns: table => new
                {
                    BileklikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BileklikAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BMadeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BTaslari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bucreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bilekliklers", x => x.BileklikId);
                });

            migrationBuilder.CreateTable(
                name: "kolyelers",
                columns: table => new
                {
                    KolyeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KolyeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KMadeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KTaslari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kucreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kolyelers", x => x.KolyeId);
                });

            migrationBuilder.CreateTable(
                name: "kupelers",
                columns: table => new
                {
                    KupeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KupMadeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KupTaslari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kupucreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kupelers", x => x.KupeId);
                });

            migrationBuilder.CreateTable(
                name: "setlers",
                columns: table => new
                {
                    SetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_setlers", x => x.SetId);
                });

            migrationBuilder.CreateTable(
                name: "yuzuklers",
                columns: table => new
                {
                    YuzukId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YuzukAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YMadeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YTaslari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yucreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yuzuklers", x => x.YuzukId);
                });

            migrationBuilder.CreateTable(
                name: "BilekliklerSetler",
                columns: table => new
                {
                    BilekliklersBileklikId = table.Column<int>(type: "int", nullable: false),
                    SetlersSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilekliklerSetler", x => new { x.BilekliklersBileklikId, x.SetlersSetId });
                    table.ForeignKey(
                        name: "FK_BilekliklerSetler_bilekliklers_BilekliklersBileklikId",
                        column: x => x.BilekliklersBileklikId,
                        principalTable: "bilekliklers",
                        principalColumn: "BileklikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BilekliklerSetler_setlers_SetlersSetId",
                        column: x => x.SetlersSetId,
                        principalTable: "setlers",
                        principalColumn: "SetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KolyelerSetler",
                columns: table => new
                {
                    KolyelersKolyeId = table.Column<int>(type: "int", nullable: false),
                    SetlersSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KolyelerSetler", x => new { x.KolyelersKolyeId, x.SetlersSetId });
                    table.ForeignKey(
                        name: "FK_KolyelerSetler_kolyelers_KolyelersKolyeId",
                        column: x => x.KolyelersKolyeId,
                        principalTable: "kolyelers",
                        principalColumn: "KolyeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KolyelerSetler_setlers_SetlersSetId",
                        column: x => x.SetlersSetId,
                        principalTable: "setlers",
                        principalColumn: "SetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KupelerSetler",
                columns: table => new
                {
                    KupelersKupeId = table.Column<int>(type: "int", nullable: false),
                    SetlersSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupelerSetler", x => new { x.KupelersKupeId, x.SetlersSetId });
                    table.ForeignKey(
                        name: "FK_KupelerSetler_kupelers_KupelersKupeId",
                        column: x => x.KupelersKupeId,
                        principalTable: "kupelers",
                        principalColumn: "KupeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupelerSetler_setlers_SetlersSetId",
                        column: x => x.SetlersSetId,
                        principalTable: "setlers",
                        principalColumn: "SetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SetlerYuzukler",
                columns: table => new
                {
                    SetlersSetId = table.Column<int>(type: "int", nullable: false),
                    YuzuklersYuzukId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetlerYuzukler", x => new { x.SetlersSetId, x.YuzuklersYuzukId });
                    table.ForeignKey(
                        name: "FK_SetlerYuzukler_setlers_SetlersSetId",
                        column: x => x.SetlersSetId,
                        principalTable: "setlers",
                        principalColumn: "SetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetlerYuzukler_yuzuklers_YuzuklersYuzukId",
                        column: x => x.YuzuklersYuzukId,
                        principalTable: "yuzuklers",
                        principalColumn: "YuzukId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BilekliklerSetler_SetlersSetId",
                table: "BilekliklerSetler",
                column: "SetlersSetId");

            migrationBuilder.CreateIndex(
                name: "IX_KolyelerSetler_SetlersSetId",
                table: "KolyelerSetler",
                column: "SetlersSetId");

            migrationBuilder.CreateIndex(
                name: "IX_KupelerSetler_SetlersSetId",
                table: "KupelerSetler",
                column: "SetlersSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SetlerYuzukler_YuzuklersYuzukId",
                table: "SetlerYuzukler",
                column: "YuzuklersYuzukId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BilekliklerSetler");

            migrationBuilder.DropTable(
                name: "KolyelerSetler");

            migrationBuilder.DropTable(
                name: "KupelerSetler");

            migrationBuilder.DropTable(
                name: "SetlerYuzukler");

            migrationBuilder.DropTable(
                name: "bilekliklers");

            migrationBuilder.DropTable(
                name: "kolyelers");

            migrationBuilder.DropTable(
                name: "kupelers");

            migrationBuilder.DropTable(
                name: "setlers");

            migrationBuilder.DropTable(
                name: "yuzuklers");
        }
    }
}
