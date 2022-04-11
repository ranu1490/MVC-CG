using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleCodeFirstInDotNetCoreMVC.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todoitem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 1L, "In Meeting need to discuss some points.", true, "Meeting With Management" });

            migrationBuilder.InsertData(
                table: "Todoitem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 2L, "List of this this item buy.", false, "Go for shopping" });

            migrationBuilder.InsertData(
                table: "Todoitem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 3L, "Here is task", false, "Call to some one for do some task" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todoitem",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Todoitem",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Todoitem",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
