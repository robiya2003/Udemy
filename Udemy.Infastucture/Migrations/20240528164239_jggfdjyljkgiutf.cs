using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy.Infastucture.Migrations
{
    /// <inheritdoc />
    public partial class jggfdjyljkgiutf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_courses_CourseModelid",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CourseModelid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CourseModelid",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "CourseModelUserModel",
                columns: table => new
                {
                    Coursesid = table.Column<int>(type: "integer", nullable: false),
                    usersId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModelUserModel", x => new { x.Coursesid, x.usersId });
                    table.ForeignKey(
                        name: "FK_CourseModelUserModel_AspNetUsers_usersId",
                        column: x => x.usersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseModelUserModel_courses_Coursesid",
                        column: x => x.Coursesid,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseModelUserModel_usersId",
                table: "CourseModelUserModel",
                column: "usersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseModelUserModel");

            migrationBuilder.AddColumn<int>(
                name: "CourseModelid",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CourseModelid",
                table: "AspNetUsers",
                column: "CourseModelid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_courses_CourseModelid",
                table: "AspNetUsers",
                column: "CourseModelid",
                principalTable: "courses",
                principalColumn: "id");
        }
    }
}
