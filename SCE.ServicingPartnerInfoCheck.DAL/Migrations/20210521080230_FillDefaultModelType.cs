using Microsoft.EntityFrameworkCore.Migrations;

namespace SCE.ServicingPartnerInfoCheck.DAL.Migrations
{
    public partial class FillDefaultModelType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("update [spInfoCheck].[SpInfoCheckEntities] set ModelType = 'SpInfoCheckResponse'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("update [spInfoCheck].[SpInfoCheckEntities] set ModelType = '' where ModelType = 'SpInfoCheckResponse'");
        }
    }
}
