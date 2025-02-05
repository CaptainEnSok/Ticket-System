using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket_System_3_Organic_Tree.Data.Migrations
{
    /// <inheritdoc />
    public partial class KnowledgeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KnownKnowledge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Knowledge_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Knowledge_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Knowledge_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownKnowledge", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnownKnowledge");
        }
    }
}
