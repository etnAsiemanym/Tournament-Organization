using Microsoft.EntityFrameworkCore.Migrations;

namespace Tournament_Organization.Migrations
{ 
    public partial class AddingTournamentEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
            name: "Tournaments",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false),
                TournamentName = table.Column<int>(nullable: false),
                Active = table.Column<bool>(nullable: true),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tournaments", x => x.Id);
            });

            migrationBuilder.CreateTable(
            name: "TeamMembers",
            columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_Id",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMembers_AspNetUsers_Id",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateTable(
            name: "TournamentEntries",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false),
                TournamentId = table.Column<int>(nullable: false),
                TeamId = table.Column<int>(nullable: true),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TournamentEntries", x => x.Id);
                table.ForeignKey(
                     name: "FK_TournamentEntries_Tournaments_Id",
                     column: x => x.TournamentId,
                     principalTable: "Tournaments",
                     principalColumn: "Id",
                     onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                     name: "FK_TournamentEntries_Teams_Id",
                     column: x => x.TeamId,
                     principalTable: "Teams",
                     principalColumn: "Id",
                     onDelete: ReferentialAction.Cascade);
            });

            migrationBuilder.CreateTable(
            name: "Matchups",
            columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    WinnerId = table.Column<int>(nullable: true),
                    MatchupRound = table.Column<int>(nullable: false),
                    TournamentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matchups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matchups_Teams_Id",
                        column: x => x.WinnerId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matchups_Tournaments_Id",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);

                });

            migrationBuilder.CreateTable(
                name: "MatchupEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    MatchupId = table.Column<int>(nullable: false),
                    ParentMatchupId = table.Column<int>(nullable: true),
                    TeamCompetingId = table.Column<int>(nullable: true),
                    ScoreTeamA = table.Column<float>(nullable: true),
                    ScoreTeamB = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchupEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchupEntries_Matchups_Id",
                        column: x => x.MatchupId,
                        principalTable: "Matchups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchupEntries_Teams_Id",
                        column: x => x.TeamCompetingId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                    name: "IX_MatchupEntries_Id",
                    table: "MatchupEntries",
                    column: "Id");

                migrationBuilder.CreateIndex(
                    name: "IX_Matchups_Id",
                    table: "Matchups",
                    column: "Id");

                migrationBuilder.CreateIndex(
                    name: "IX_TeamMembers_Id",
                    table: "TeamMembers",
                    column: "Id");

                migrationBuilder.CreateIndex(
                    name: "IX_Teams_Id",
                    table: "Teams",
                    column: "Id");

                migrationBuilder.CreateIndex(
                    name: "IX_TournamentEntries_Id",
                    table: "TournamentEntries",
                    column: "Id");

                migrationBuilder.CreateIndex(
                    name: "IX_Tournaments_Id",
                    table: "Tournaments",
                    column: "Id");
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "MatchupEntries");
            
            migrationBuilder.DropTable(
                name: "Matchups");
            
            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "TournamentEntries");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
