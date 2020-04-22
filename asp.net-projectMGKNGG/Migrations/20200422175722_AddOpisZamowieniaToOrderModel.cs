using Microsoft.EntityFrameworkCore.Migrations;

namespace asp.net_projectMGKNGG.Migrations
{
    public partial class AddOpisZamowieniaToOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Order",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "OpisZamowienia",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpisZamowienia",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "Author",
                table: "Order",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
