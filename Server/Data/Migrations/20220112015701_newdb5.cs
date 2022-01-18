using Microsoft.EntityFrameworkCore.Migrations;

namespace Project5.Server.Data.Migrations
{
    public partial class newdb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Event_details",
                columns: new[] { "Id", "Category", "EventsId", "Venue" },
                values: new object[] { 1, "Studies", 1, "Classroom" });

            migrationBuilder.InsertData(
                table: "Event_details",
                columns: new[] { "Id", "Category", "EventsId", "Venue" },
                values: new object[] { 2, "Entertainment", 2, "Lab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event_details",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event_details",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
