using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore_MVC.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_Books_BookId",
                table: "CustomerBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_Customer_CustomerId",
                table: "CustomerBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "customer");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.AddColumn<bool>(
                name: "ReturnedOrNot",
                table: "CustomerBooks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer",
                table: "customer",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_books_BookId",
                table: "CustomerBooks",
                column: "BookId",
                principalTable: "books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_customer_CustomerId",
                table: "CustomerBooks",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_books_BookId",
                table: "CustomerBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_customer_CustomerId",
                table: "CustomerBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer",
                table: "customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropColumn(
                name: "ReturnedOrNot",
                table: "CustomerBooks");

            migrationBuilder.RenameTable(
                name: "customer",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_Books_BookId",
                table: "CustomerBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_Customer_CustomerId",
                table: "CustomerBooks",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
