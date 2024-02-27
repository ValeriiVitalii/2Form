using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2FormNew.Migrations
{
    /// <inheritdoc />
    public partial class RefractorCategoryAndDp20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatId",
                table: "DpWithoutValues");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "DpWithoutValues",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
