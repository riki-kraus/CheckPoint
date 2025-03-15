using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheckPoint.Data.Migrations
{
    /// <inheritdoc />
    public partial class renameQesNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumAns",
                table: "Answers",
                newName: "QesNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QesNumber",
                table: "Answers",
                newName: "NumAns");
        }
    }
}
