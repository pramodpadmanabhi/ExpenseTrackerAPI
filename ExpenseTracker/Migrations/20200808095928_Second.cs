using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTracker.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Expense_CategoryId",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expense",
                table: "Expense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Expense",
                newName: "ExpenseSet");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "CategorySet");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ExpenseSet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpenseSet",
                table: "ExpenseSet",
                column: "ExpenseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySet",
                table: "CategorySet",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySet_ExpenseSet_CategoryId",
                table: "CategorySet",
                column: "CategoryId",
                principalTable: "ExpenseSet",
                principalColumn: "ExpenseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySet_ExpenseSet_CategoryId",
                table: "CategorySet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpenseSet",
                table: "ExpenseSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySet",
                table: "CategorySet");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ExpenseSet");

            migrationBuilder.RenameTable(
                name: "ExpenseSet",
                newName: "Expense");

            migrationBuilder.RenameTable(
                name: "CategorySet",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expense",
                table: "Expense",
                column: "ExpenseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Expense_CategoryId",
                table: "Category",
                column: "CategoryId",
                principalTable: "Expense",
                principalColumn: "ExpenseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
