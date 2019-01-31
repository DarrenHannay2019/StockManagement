using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class addListToWarehouseadjustment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarehouseAdjustmentsWarehouseAdjustID",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Warehouse",
                column: "WarehouseAdjustmentsWarehouseAdjustID");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_WarehouseAdjustment_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Warehouse",
                column: "WarehouseAdjustmentsWarehouseAdjustID",
                principalTable: "WarehouseAdjustment",
                principalColumn: "WarehouseAdjustID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_WarehouseAdjustment_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "WarehouseAdjustmentsWarehouseAdjustID",
                table: "Warehouse");
        }
    }
}
