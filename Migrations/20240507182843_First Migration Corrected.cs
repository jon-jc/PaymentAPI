﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrationCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
    name: "PaymentDetails",
    columns: table => new
    {
        PaymentDetailId = table.Column<int>(type: "int", nullable: false),
        CardOwnerName = table.Column<string>(type: "varchar(100)", nullable: false),
        CardNumber = table.Column<string>(type: "varchar(16)", nullable: false),
        ExpirationDate = table.Column<string>(type: "varchar(5)", nullable: false),
        SecurityCode = table.Column<string>(type: "varchar(3)", nullable: false),
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailId);
    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");
        }
    }
}
