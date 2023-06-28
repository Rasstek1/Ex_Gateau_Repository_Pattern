using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex_Gateau_Repository_Pattern.Migrations
{
    /// <inheritdoc />
    public partial class string_ingredient_to_List : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Gateaux");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Gateaux",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
