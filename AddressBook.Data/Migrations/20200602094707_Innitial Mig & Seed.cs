using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Data.Migrations
{
    public partial class InnitialMigSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    WorkNumber = table.Column<string>(nullable: true),
                    HomeNumber = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(maxLength: 100, nullable: true),
                    WorkAddress = table.Column<string>(maxLength: 100, nullable: true),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "EmailAddress", "FirstName", "HomeAddress", "HomeNumber", "LastName", "MobileNumber", "WorkAddress", "WorkNumber" },
                values: new object[] { 1, "bobansrezovski@gmail.com", "Boban", "Gjorgji Abadziev no.8", null, "Srezovski", "075-314-353", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
