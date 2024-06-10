using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bshbbackend.Migrations
{
    /// <inheritdoc />
    public partial class logo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Img8",
                table: "HeaderLogos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Img9",
                table: "HeaderLogos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url8",
                table: "HeaderLogos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url9",
                table: "HeaderLogos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img8",
                table: "HeaderLogos");

            migrationBuilder.DropColumn(
                name: "Img9",
                table: "HeaderLogos");

            migrationBuilder.DropColumn(
                name: "url8",
                table: "HeaderLogos");

            migrationBuilder.DropColumn(
                name: "url9",
                table: "HeaderLogos");
        }
    }
}
