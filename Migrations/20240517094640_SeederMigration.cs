using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLib.Migrations
{
    public partial class SeederMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Book (Title, Author, Description, Language," +
                " ISBN, NumberOfPages, Publisher, PhotoUrl, PublicId, CopiesInLibrary" +
                "AddedBy, PublishedDate, BookVersion, CategoryId, SubcategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
