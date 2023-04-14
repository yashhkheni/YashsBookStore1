using Microsoft.EntityFrameworkCore.Migrations;

namespace YashsBookStore.DataAccess.Migrations
{
    public partial class AddProductToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CoverType",
                table: "CoverType");

            migrationBuilder.RenameTable(
                name: "CoverType",
                newName: "CoverTypes");

            migrationBuilder.AddColumn<string>(
                name: "Auther",
                table: "CoverTypes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CoverTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CoverTypeId",
                table: "CoverTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CoverTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "CoverTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "CoverTypes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ListPrice",
                table: "CoverTypes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CoverTypes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoverTypes",
                table: "CoverTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: false),
                    Auther = table.Column<string>(nullable: false),
                    ListPrice = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CoverTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CoverTypes_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CoverTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoverTypes",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "Auther",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "CoverTypeId",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "ListPrice",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CoverTypes");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                newName: "CoverType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoverType",
                table: "CoverType",
                column: "Id");
        }
    }
}
