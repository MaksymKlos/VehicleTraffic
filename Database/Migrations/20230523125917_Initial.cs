using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Водії",
                columns: table => new
                {
                    Код_Водія = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Імя = table.Column<string>(type: "TEXT", nullable: true),
                    Прізвище = table.Column<string>(type: "TEXT", nullable: true),
                    Номер_Телефону = table.Column<string>(type: "TEXT", nullable: true),
                    Адреса = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Водії", x => x.Код_Водія);
                });

            migrationBuilder.CreateTable(
                name: "Маршрути",
                columns: table => new
                {
                    Код_Маршруту = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Назва = table.Column<string>(type: "TEXT", nullable: true),
                    Початкова_Точка = table.Column<string>(type: "TEXT", nullable: true),
                    Кінцева_Точка = table.Column<string>(type: "TEXT", nullable: true),
                    Протяжність_Маршруту = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Маршрути", x => x.Код_Маршруту);
                });

            migrationBuilder.CreateTable(
                name: "ТрансортніЗасоби",
                columns: table => new
                {
                    Код_Транспорту = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Марка = table.Column<string>(type: "TEXT", nullable: false),
                    Модель = table.Column<string>(type: "TEXT", nullable: false),
                    VIN = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ТрансортніЗасоби", x => x.Код_Транспорту);
                });

            migrationBuilder.CreateTable(
                name: "Перевезення",
                columns: table => new
                {
                    Код_Перевезення = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ВодійКод_Водія = table.Column<int>(type: "INTEGER", nullable: false),
                    ТранспортКод_Транспорту = table.Column<int>(type: "INTEGER", nullable: false),
                    МаршрутКод_Маршруту = table.Column<int>(type: "INTEGER", nullable: false),
                    Початок = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Завершення = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Перевезення", x => x.Код_Перевезення);
                    table.ForeignKey(
                        name: "FK_Перевезення_Водії_ВодійКод_Водія",
                        column: x => x.ВодійКод_Водія,
                        principalTable: "Водії",
                        principalColumn: "Код_Водія",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Перевезення_Маршрути_МаршрутКод_Маршруту",
                        column: x => x.МаршрутКод_Маршруту,
                        principalTable: "Маршрути",
                        principalColumn: "Код_Маршруту",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Перевезення_ТрансортніЗасоби_ТранспортКод_Транспорту",
                        column: x => x.ТранспортКод_Транспорту,
                        principalTable: "ТрансортніЗасоби",
                        principalColumn: "Код_Транспорту",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Штрафи",
                columns: table => new
                {
                    Код_Штрафу = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ВодійКод_Водія = table.Column<int>(type: "INTEGER", nullable: false),
                    ТранспортКод_Транспорту = table.Column<int>(type: "INTEGER", nullable: false),
                    Опис = table.Column<string>(type: "TEXT", nullable: true),
                    Сума = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Штрафи", x => x.Код_Штрафу);
                    table.ForeignKey(
                        name: "FK_Штрафи_Водії_ВодійКод_Водія",
                        column: x => x.ВодійКод_Водія,
                        principalTable: "Водії",
                        principalColumn: "Код_Водія",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Штрафи_ТрансортніЗасоби_ТранспортКод_Транспорту",
                        column: x => x.ТранспортКод_Транспорту,
                        principalTable: "ТрансортніЗасоби",
                        principalColumn: "Код_Транспорту",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Перевезення_ВодійКод_Водія",
                table: "Перевезення",
                column: "ВодійКод_Водія");

            migrationBuilder.CreateIndex(
                name: "IX_Перевезення_МаршрутКод_Маршруту",
                table: "Перевезення",
                column: "МаршрутКод_Маршруту");

            migrationBuilder.CreateIndex(
                name: "IX_Перевезення_ТранспортКод_Транспорту",
                table: "Перевезення",
                column: "ТранспортКод_Транспорту");

            migrationBuilder.CreateIndex(
                name: "IX_Штрафи_ВодійКод_Водія",
                table: "Штрафи",
                column: "ВодійКод_Водія");

            migrationBuilder.CreateIndex(
                name: "IX_Штрафи_ТранспортКод_Транспорту",
                table: "Штрафи",
                column: "ТранспортКод_Транспорту");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Перевезення");

            migrationBuilder.DropTable(
                name: "Штрафи");

            migrationBuilder.DropTable(
                name: "Маршрути");

            migrationBuilder.DropTable(
                name: "Водії");

            migrationBuilder.DropTable(
                name: "ТрансортніЗасоби");
        }
    }
}
