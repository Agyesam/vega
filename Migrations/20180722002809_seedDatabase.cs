using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Make1', 'Make2', 'Make3')");
        }
    }
}
