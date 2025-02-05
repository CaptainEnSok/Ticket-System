using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket_System_3_Organic_Tree.Data.Migrations
{
    /// <inheritdoc />
    public partial class Knowledge2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Knowledge_Type",
                table: "KnownKnowledge",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Knowledge_Name",
                table: "KnownKnowledge",
                newName: "Problem");

            migrationBuilder.RenameColumn(
                name: "Knowledge_Description",
                table: "KnownKnowledge",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "KnownKnowledge",
                newName: "Knowledge_Type");

            migrationBuilder.RenameColumn(
                name: "Problem",
                table: "KnownKnowledge",
                newName: "Knowledge_Name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "KnownKnowledge",
                newName: "Knowledge_Description");
        }
    }
}
