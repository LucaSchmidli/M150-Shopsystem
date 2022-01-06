using Microsoft.EntityFrameworkCore.Migrations;

namespace WhackTech.Data.Migrations
{
    public partial class ApplicationUserUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodID",
                table: "Orders");

            //migrationBuilder.DropColumn(
            //    name: "Phone",
            //    table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "ShoppingCartId",
            //    table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "imgURL",
                table: "Products",
                newName: "ImgURL");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethodID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            //migrationBuilder.AddColumn<int>( //
            //    name: "ApplicationUserID",
            //    table: "Orders",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingCartID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodID",
                table: "Orders",
                column: "PaymentMethodID",
                principalTable: "PaymentMethods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodID",
                table: "Orders");

            migrationBuilder.DropColumn( //
                name: "ApplicationUserID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ImgURL",
                table: "Products",
                newName: "imgURL");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethodID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingCartID",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodID",
                table: "Orders",
                column: "PaymentMethodID",
                principalTable: "PaymentMethods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
