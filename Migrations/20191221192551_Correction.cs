using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WhatToDo.Migrations
{
    public partial class Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDo_ToDo_ToDoId",
                table: "ToDo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDo",
                table: "ToDo");

            migrationBuilder.DropIndex(
                name: "IX_ToDo_ToDoId",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "ToDoId",
                table: "ToDo");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ToDo",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToDoName",
                table: "ToDo",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDo",
                table: "ToDo",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_ToDoName",
                table: "ToDo",
                column: "ToDoName");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDo_ToDo_ToDoName",
                table: "ToDo",
                column: "ToDoName",
                principalTable: "ToDo",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDo_ToDo_ToDoName",
                table: "ToDo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDo",
                table: "ToDo");

            migrationBuilder.DropIndex(
                name: "IX_ToDo_ToDoName",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "ToDoName",
                table: "ToDo");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ToDo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ToDo",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ToDoId",
                table: "ToDo",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDo",
                table: "ToDo",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_ToDoId",
                table: "ToDo",
                column: "ToDoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDo_ToDo_ToDoId",
                table: "ToDo",
                column: "ToDoId",
                principalTable: "ToDo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
