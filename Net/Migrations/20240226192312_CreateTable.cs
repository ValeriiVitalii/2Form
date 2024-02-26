using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2FormNew.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dp_without_value_Categories_CategoryId",
                table: "dp_without_value");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dp_without_value",
                table: "dp_without_value");

            migrationBuilder.RenameTable(
                name: "dp_without_value",
                newName: "DpWithoutValues");

            migrationBuilder.RenameIndex(
                name: "IX_dp_without_value_CategoryId",
                table: "DpWithoutValues",
                newName: "IX_DpWithoutValues_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DpWithoutValues",
                table: "DpWithoutValues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DpWithoutValues_Categories_CategoryId",
                table: "DpWithoutValues",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DpWithoutValues_Categories_CategoryId",
                table: "DpWithoutValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DpWithoutValues",
                table: "DpWithoutValues");

            migrationBuilder.RenameTable(
                name: "DpWithoutValues",
                newName: "dp_without_value");

            migrationBuilder.RenameIndex(
                name: "IX_DpWithoutValues_CategoryId",
                table: "dp_without_value",
                newName: "IX_dp_without_value_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dp_without_value",
                table: "dp_without_value",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dp_without_value_Categories_CategoryId",
                table: "dp_without_value",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
