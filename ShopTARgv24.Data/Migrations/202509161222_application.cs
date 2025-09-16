using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopTARgv24.Data.Migrations
{
    internal class _202509161222_application
    {
    }
}



ProtectedData override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.CreateTable(
        name: "FileToApis",
        columns: table => new
        {
            Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            ExistingFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            SpaceshipId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_FileToApis", x => x.Id);
        });
}
/// <inheritdoc/>

protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.DropTable(
        name: "FileToApis");
}

