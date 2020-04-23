using Microsoft.EntityFrameworkCore.Migrations;

namespace Ghost.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SecondTeacherId",
                table: "Course",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FirstTeacherId",
                table: "Course",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Course_FirstTeacherId",
                table: "Course",
                column: "FirstTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_SecondTeacherId",
                table: "Course",
                column: "SecondTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_FirstTeacherId",
                table: "Course",
                column: "FirstTeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_SecondTeacherId",
                table: "Course",
                column: "SecondTeacherId",
                principalTable: "Teacher",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_FirstTeacherId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_SecondTeacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_FirstTeacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_SecondTeacherId",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "SecondTeacherId",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstTeacherId",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
