using Microsoft.EntityFrameworkCore.Migrations;

namespace TranThiLua681.Migrations
{
    public partial class PersonTTL681 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonTTL681",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PersonName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTTL681", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonTTL681");
        }
    }
}
