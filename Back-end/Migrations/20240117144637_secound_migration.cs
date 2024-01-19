using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalHub.Migrations
{
    /// <inheritdoc />
    public partial class secound_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Enrols_Assessments_assessment_id",
                table: "Assessment_Enrols");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Enrols_Users_User_id",
                table: "Assessment_Enrols");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_Questions_question_id",
                table: "Assessment_Questions_Relations");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_assesment_id",
                table: "Assessment_Questions_Relations");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Assessments_Questions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Assessments_Questions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "question_id",
                table: "Assessment_Questions_Relations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "assesment_id",
                table: "Assessment_Questions_Relations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "assessment_id",
                table: "Assessment_Enrols",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "User_id",
                table: "Assessment_Enrols",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Assessment_Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    question_id = table.Column<int>(type: "int", nullable: true),
                    assessment_id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessment_Answers_Assessments_Questions_question_id",
                        column: x => x.question_id,
                        principalTable: "Assessments_Questions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_Answers_Assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "Assessments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_Answers_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Option = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correct = table.Column<byte>(type: "tinyint", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    question_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessment_Options_Assessments_Questions_question_id",
                        column: x => x.question_id,
                        principalTable: "Assessments_Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Texts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question_id = table.Column<int>(type: "int", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Texts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessment_Texts_Assessments_Questions_question_id",
                        column: x => x.question_id,
                        principalTable: "Assessments_Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_True_Falses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Is_true = table.Column<bool>(type: "bit", nullable: false),
                    question_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_True_Falses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessment_True_Falses_Assessments_Questions_question_id",
                        column: x => x.question_id,
                        principalTable: "Assessments_Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assesstment_Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question_id = table.Column<int>(type: "int", nullable: true),
                    Option = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assesstment_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assesstment_Matches_Assessments_Questions_question_id",
                        column: x => x.question_id,
                        principalTable: "Assessments_Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Answers_assessment_id",
                table: "Assessment_Answers",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Answers_question_id",
                table: "Assessment_Answers",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Answers_user_id",
                table: "Assessment_Answers",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Options_question_id",
                table: "Assessment_Options",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Texts_question_id",
                table: "Assessment_Texts",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_True_Falses_question_id",
                table: "Assessment_True_Falses",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_Assesstment_Matches_question_id",
                table: "Assesstment_Matches",
                column: "question_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Enrols_Assessments_assessment_id",
                table: "Assessment_Enrols",
                column: "assessment_id",
                principalTable: "Assessments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Enrols_Users_User_id",
                table: "Assessment_Enrols",
                column: "User_id",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_Questions_question_id",
                table: "Assessment_Questions_Relations",
                column: "question_id",
                principalTable: "Assessments_Questions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_assesment_id",
                table: "Assessment_Questions_Relations",
                column: "assesment_id",
                principalTable: "Assessments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Enrols_Assessments_assessment_id",
                table: "Assessment_Enrols");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Enrols_Users_User_id",
                table: "Assessment_Enrols");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_Questions_question_id",
                table: "Assessment_Questions_Relations");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_assesment_id",
                table: "Assessment_Questions_Relations");

            migrationBuilder.DropTable(
                name: "Assessment_Answers");

            migrationBuilder.DropTable(
                name: "Assessment_Options");

            migrationBuilder.DropTable(
                name: "Assessment_Texts");

            migrationBuilder.DropTable(
                name: "Assessment_True_Falses");

            migrationBuilder.DropTable(
                name: "Assesstment_Matches");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Assessments_Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Assessments_Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "question_id",
                table: "Assessment_Questions_Relations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "assesment_id",
                table: "Assessment_Questions_Relations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "assessment_id",
                table: "Assessment_Enrols",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User_id",
                table: "Assessment_Enrols",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Enrols_Assessments_assessment_id",
                table: "Assessment_Enrols",
                column: "assessment_id",
                principalTable: "Assessments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Enrols_Users_User_id",
                table: "Assessment_Enrols",
                column: "User_id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_Questions_question_id",
                table: "Assessment_Questions_Relations",
                column: "question_id",
                principalTable: "Assessments_Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Questions_Relations_Assessments_assesment_id",
                table: "Assessment_Questions_Relations",
                column: "assesment_id",
                principalTable: "Assessments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
