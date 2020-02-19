using Microsoft.EntityFrameworkCore.Migrations;

namespace HeedTheCall.Migrations
{
    public partial class CreateTrendDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trends",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    url = table.Column<string>(nullable: true),
                    promoted_content = table.Column<string>(nullable: true),
                    query = table.Column<long>(nullable: true),
                    tweet_volume = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trends", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trends");
        }
    }
}
