using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CommunityResources.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Additional_Comments = table.Column<string>(nullable: true),
                    Appointments_Available = table.Column<int>(nullable: false),
                    Appointments_Required = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Other_Requirements = table.Column<int>(nullable: false),
                    Other_Requirements_Text = table.Column<string>(nullable: true),
                    Photo_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Street_Address = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Clothing = table.Column<int>(nullable: false),
                    Education = table.Column<int>(nullable: false),
                    Employment = table.Column<int>(nullable: false),
                    Finances = table.Column<int>(nullable: false),
                    Food = table.Column<int>(nullable: false),
                    Housing = table.Column<int>(nullable: false),
                    Medical_Prescription = table.Column<int>(nullable: false),
                    Natural_Disaster = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    Other_Resources = table.Column<int>(nullable: false),
                    Other_Resources_Text = table.Column<string>(nullable: true),
                    Rent_Utilities = table.Column<int>(nullable: false),
                    Senior = table.Column<int>(nullable: false),
                    Veterans = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resource_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    TimesId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Day = table.Column<string>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: false),
                    Repeat = table.Column<int>(nullable: false),
                    Time_End = table.Column<string>(nullable: true),
                    Time_Start = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.TimesId);
                    table.ForeignKey(
                        name: "FK_Time_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_OrganizationId",
                table: "Contact",
                column: "OrganizationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resource_OrganizationId",
                table: "Resource",
                column: "OrganizationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Time_OrganizationId",
                table: "Time",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "Time");

            migrationBuilder.DropTable(
                name: "Organization");
        }
    }
}
