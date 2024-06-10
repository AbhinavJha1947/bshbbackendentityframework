using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bshbbackend.Migrations
{
    /// <inheritdoc />
    public partial class officerlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "OfficerLists");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "OfficerLists");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "OfficerLists",
                type: "VARBINARY(MAX)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "VARBINARY(MAX)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OfficerLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "OfficerLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "details",
                table: "OfficerLists",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "details",
                table: "OfficerLists");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "OfficerLists",
                type: "VARBINARY(MAX)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "VARBINARY(MAX)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OfficerLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "OfficerLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "OfficerLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "OfficerLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
