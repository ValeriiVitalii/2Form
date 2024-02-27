using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2FormNew.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUseCatIdNullableV20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseCatId",
                table: "DpWithoutValues");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<int>>(
                name: "UseCatId",
                table: "DpWithoutValues",
                type: "integer[]",
                nullable: false);
        }
    }
}
