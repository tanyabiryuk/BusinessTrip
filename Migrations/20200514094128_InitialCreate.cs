using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessTrip.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foundation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trip_Foundation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foundation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "App_Fundation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(nullable: false),
                    FundationId = table.Column<int>(nullable: false),
                    FoundationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_App_Fundation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_App_Fundation_Foundation_FoundationId",
                        column: x => x.FoundationId,
                        principalTable: "Foundation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "App_Transport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(nullable: false),
                    TransportId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_App_Transport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_App_Transport_Transport_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    Main_place_of_work = table.Column<string>(nullable: true),
                    Position_in_combination = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Saving_salary = table.Column<string>(nullable: true),
                    Trip_city = table.Column<string>(nullable: true),
                    Trip_country = table.Column<string>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    Start_date = table.Column<DateTime>(nullable: false),
                    End_date = table.Column<DateTime>(nullable: false),
                    Itinerary = table.Column<string>(nullable: true),
                    App_transport_Id = table.Column<int>(nullable: true),
                    Payment = table.Column<string>(nullable: true),
                    App_fundation_Id = table.Column<int>(nullable: false),
                    InstitutionLocation = table.Column<string>(nullable: true),
                    App_fundationId = table.Column<int>(nullable: true),
                    app_transportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_App_Fundation_App_fundationId",
                        column: x => x.App_fundationId,
                        principalTable: "App_Fundation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Application_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_App_Transport_app_transportId",
                        column: x => x.app_transportId,
                        principalTable: "App_Transport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_App_Fundation_FoundationId",
                table: "App_Fundation",
                column: "FoundationId");

            migrationBuilder.CreateIndex(
                name: "IX_App_Transport_TransportId",
                table: "App_Transport",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_App_fundationId",
                table: "Application",
                column: "App_fundationId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_UserId",
                table: "Application",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_app_transportId",
                table: "Application",
                column: "app_transportId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "App_Fundation");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "App_Transport");

            migrationBuilder.DropTable(
                name: "Foundation");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Transport");
        }
    }
}
