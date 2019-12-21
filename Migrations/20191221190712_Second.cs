using Microsoft.EntityFrameworkCore.Migrations;

namespace WhatToDo.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KindOfToDo",
                table: "ToDo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ToDo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToDoId",
                table: "ToDo",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDo_ToDo_ToDoId",
                table: "ToDo");

            migrationBuilder.DropIndex(
                name: "IX_ToDo_ToDoId",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "KindOfToDo",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "ToDoId",
                table: "ToDo");
        }
    }
}
