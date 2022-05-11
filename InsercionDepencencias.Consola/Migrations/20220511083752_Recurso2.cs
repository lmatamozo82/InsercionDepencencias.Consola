using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsercionDepencencias.Consola.Migrations
{
    public partial class Recurso2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recursos",
                columns: new[] { "Id", "Denominacion" },
                values: new object[,]
                {
                    { 1, "Video_1" },
                    { 2, "Video_2" },
                    { 3, "Imagen_1" },
                    { 4, "Imagen_2" },
                    { 5, "HTML5_1" },
                    { 6, "HTML5_2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recursos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recursos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recursos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recursos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recursos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recursos",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
