using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeBasedApproach.Migrations
{
    /// <inheritdoc />
    public partial class Storedprocedure2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create or alter procedure Student_Course(@course_id int) as 
                                Select * from Students where CourseId=@course_id";

            migrationBuilder.Sql(procedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop procedure Student_Course";

            migrationBuilder.Sql(procedure);
        }
    }
}
