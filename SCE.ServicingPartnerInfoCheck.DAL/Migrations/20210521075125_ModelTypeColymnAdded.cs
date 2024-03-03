using Microsoft.EntityFrameworkCore.Migrations;

namespace SCE.ServicingPartnerInfoCheck.DAL.Migrations
{
    public partial class ModelTypeColymnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModelType",
                schema: "spInfoCheck",
                table: "SpInfoCheckEntities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelType",
                schema: "spInfoCheck",
                table: "SpInfoCheckEntities");
        }
    }
}
