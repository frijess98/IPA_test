using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCE.ServicingPartnerInfoCheck.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "spInfoCheck");

            migrationBuilder.CreateTable(
                name: "SpInfoCheckEntities",
                schema: "spInfoCheck",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RequestId = table.Column<string>(nullable: true),
                    ServicingPartnerKey = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsSuccessful = table.Column<bool>(nullable: false),
                    ResponseJSON = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpInfoCheckEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpInfoCheckEntities",
                schema: "spInfoCheck");
        }
    }
}
