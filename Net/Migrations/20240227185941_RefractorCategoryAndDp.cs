using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2FormNew.Migrations
{
    /// <inheritdoc />
    public partial class RefractorCategoryAndDp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DpWithoutValues_Categories_CategoryId",
                table: "DpWithoutValues");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "DpWithoutValues",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "DpWithoutValues",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DpWithoutValues_Categories_CategoryId",
                table: "DpWithoutValues",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DpWithoutValues_Categories_CategoryId",
                table: "DpWithoutValues");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "DpWithoutValues");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "DpWithoutValues",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_DpWithoutValues_Categories_CategoryId",
                table: "DpWithoutValues",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
