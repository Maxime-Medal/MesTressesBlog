using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class BaseInfodeleteID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "LevelTranslations");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "DomainTranslation");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Domain");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "DocumentTranslations");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Competence");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "CategoriesTranslations");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "ArticleTranslations");

            migrationBuilder.DropColumn(
                name: "BaseInfo_Id",
                table: "Articles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Roles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "LevelTranslations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Levels",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Languages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Grades",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "DomainTranslation",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Domain",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "DocumentTranslations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Documents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Competence",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Comments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Classrooms",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "CategoriesTranslations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "ArticleTranslations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseInfo_Id",
                table: "Articles",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
