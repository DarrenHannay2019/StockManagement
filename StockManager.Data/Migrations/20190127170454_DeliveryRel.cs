using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class DeliveryRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderID",
                table: "PurchaseOrder",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLines_DeliveryID",
                table: "PurchaseOrderLines",
                column: "DeliveryID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderLines_PurchaseOrder_DeliveryID",
                table: "PurchaseOrderLines",
                column: "DeliveryID",
                principalTable: "PurchaseOrder",
                principalColumn: "DeliveryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderLines_PurchaseOrder_DeliveryID",
                table: "PurchaseOrderLines");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderLines_DeliveryID",
                table: "PurchaseOrderLines");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderID",
                table: "PurchaseOrder");
        }
    }
}
