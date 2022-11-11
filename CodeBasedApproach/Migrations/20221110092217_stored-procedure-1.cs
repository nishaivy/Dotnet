using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeBasedApproach.Migrations
{
    /// <inheritdoc />
    public partial class storedprocedure1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create or alter procedure Student_Club(@club_id int) as 
                                Select * from Students where ClubId=@club_id";

            migrationBuilder.Sql(procedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop procedure Student_Club";

            migrationBuilder.Sql(procedure);
        }

    }
    
}
