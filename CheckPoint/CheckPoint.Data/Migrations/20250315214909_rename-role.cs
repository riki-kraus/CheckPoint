﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheckPoint.Data.Migrations
{
    /// <inheritdoc />
    public partial class renamerole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Users",
                newName: "Role");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "Discriminator");
        }
    }
}
