using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bshbbackend.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url",
                table: "Notices",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "updatedon",
                table: "Notices",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "Notices",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Notices",
                newName: "Text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Notices",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Notices",
                newName: "updatedon");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Notices",
                newName: "createdon");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Notices",
                newName: "description");
        }
    }
}
