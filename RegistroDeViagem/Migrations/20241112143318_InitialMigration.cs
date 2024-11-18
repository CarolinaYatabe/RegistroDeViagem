using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TravelCompanions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelCompanions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TravelStatisticsId = table.Column<int>(type: "int", nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalTrips = table.Column<int>(type: "int", nullable: false),
                    TotalVisitedLocations = table.Column<int>(type: "int", nullable: false),
                    TotalPhotos = table.Column<int>(type: "int", nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelStatistics_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TripName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TripStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TripEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Album_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itinerary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    DepartureLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartureDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itinerary_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    ExpenseName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelExpenses_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TripTravelCompanions",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false),
                    TravelCompanionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripTravelCompanions", x => new { x.TravelCompanionId, x.TripId });
                    table.ForeignKey(
                        name: "FK_TripTravelCompanions_TravelCompanions_TravelCompanionId",
                        column: x => x.TravelCompanionId,
                        principalTable: "TravelCompanions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripTravelCompanions_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitedLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    LocationDescription = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitedLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitedLocations_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Photo_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_TripId",
                table: "Album",
                column: "TripId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Itinerary_TripId",
                table: "Itinerary",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AlbumId",
                table: "Photo",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_TripId",
                table: "Photo",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_TripId",
                table: "Rating",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelExpenses_TripId",
                table: "TravelExpenses",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelStatistics_UserId",
                table: "TravelStatistics",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_UserId",
                table: "Trips",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTravelCompanions_TripId",
                table: "TripTravelCompanions",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitedLocations_TripId",
                table: "VisitedLocations",
                column: "TripId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itinerary");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "TravelExpenses");

            migrationBuilder.DropTable(
                name: "TravelStatistics");

            migrationBuilder.DropTable(
                name: "TripTravelCompanions");

            migrationBuilder.DropTable(
                name: "VisitedLocations");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "TravelCompanions");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
