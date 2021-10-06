using Microsoft.EntityFrameworkCore.Migrations;

namespace TranThiLua681.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TTL681",
                columns: table => new
                {
                    TLLId = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TTLName = table.Column<string>(type: "TEXT", nullable: true),
                    TTLGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTL681", x => x.TLLId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TTL681");
        }
    }
}
