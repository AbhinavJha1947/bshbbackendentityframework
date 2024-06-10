using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bshbbackend.Migrations
{
    /// <inheritdoc />
    public partial class subnotice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url",
                table: "SubNotices",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "updatedon",
                table: "SubNotices",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "SubNotices",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "SubNotices",
                newName: "CreatedOn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "SubNotices",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "SubNotices",
                newName: "updatedon");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "SubNotices",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "SubNotices",
                newName: "createdon");
        }
    }
}
