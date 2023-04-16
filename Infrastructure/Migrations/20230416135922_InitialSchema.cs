using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    display_text = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    created_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    modified_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "difficulties",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    display_text = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    created_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    modified_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_difficulties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    display_text = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    created_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    modified_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    question_text = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    answer_options = table.Column<List<string>>(type: "character varying[]", nullable: false),
                    correct_answer = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    difficulty_id = table.Column<int>(type: "integer", nullable: false),
                    category_id = table.Column<int>(type: "integer", nullable: false),
                    created_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    modified_by = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.id);
                    table.ForeignKey(
                        name: "FK_questions_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_questions_difficulties_difficulty_id",
                        column: x => x.difficulty_id,
                        principalTable: "difficulties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "question_tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    question_id = table.Column<int>(type: "integer", nullable: false),
                    tag_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_question_tags", x => x.id);
                    table.ForeignKey(
                        name: "FK_question_tags_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_question_tags_tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "created_by", "created_utc", "display_text", "modified_by", "modified_utc", "value" },
                values: new object[,]
                {
                    { 1, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1737), "computer science", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1738), "computer_science" },
                    { 2, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1741), "backend", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1742), "backend" },
                    { 3, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1742), "frontend", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1743), "frontend" },
                    { 4, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1743), "databases", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1744), "databases" },
                    { 5, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1744), "object-oriented", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(1745), "object_oriented" }
                });

            migrationBuilder.InsertData(
                table: "difficulties",
                columns: new[] { "id", "created_by", "created_utc", "display_text", "modified_by", "modified_utc" },
                values: new object[,]
                {
                    { 1, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(2300), "easy", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(2301) },
                    { 2, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(2303), "medium", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(2303) },
                    { 3, "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(2304), "hard", "initial_create", new DateTime(2023, 4, 16, 13, 59, 22, 758, DateTimeKind.Utc).AddTicks(2304) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_value",
                table: "categories",
                column: "value",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_difficulties_display_text",
                table: "difficulties",
                column: "display_text",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_question_tags_question_id",
                table: "question_tags",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_tags_tag_id",
                table: "question_tags",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_questions_category_id",
                table: "questions",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_questions_difficulty_id",
                table: "questions",
                column: "difficulty_id");

            migrationBuilder.CreateIndex(
                name: "IX_questions_question_text",
                table: "questions",
                column: "question_text",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "question_tags");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "difficulties");
        }
    }
}
