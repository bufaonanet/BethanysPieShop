using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BethanysPieShop.Migrations
{
    public partial class renameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCardItems_Pies_PieId",
                table: "ShoppingCardItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCardItems",
                table: "ShoppingCardItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCardItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCardItems_PieId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCardItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_PieId",
                table: "ShoppingCardItems",
                newName: "IX_ShoppingCardItems_PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCardItems",
                table: "ShoppingCardItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCardItems_Pies_PieId",
                table: "ShoppingCardItems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
