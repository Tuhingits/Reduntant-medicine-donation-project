using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reduntant_Medicine_Donation_portal.Migrations
{
    public partial class InitialTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DonarId",
                table: "DonateMedicines",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "DonarId",
                table: "DonateMedicines",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
