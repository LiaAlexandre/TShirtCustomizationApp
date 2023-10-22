using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TShirtCustomizationApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class addingImage64Field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image64",
                table: "Image",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image64",
                table: "Image");
        }
    }
}
