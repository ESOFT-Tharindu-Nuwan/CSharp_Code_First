using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class add_address_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Lecturers");
        }
    }
}
