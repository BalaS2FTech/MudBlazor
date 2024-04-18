using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudBlazor.Migrations
{
    /// <inheritdoc />
    public partial class FirstQuote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "quotes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "quotes");
        }
    }
}
