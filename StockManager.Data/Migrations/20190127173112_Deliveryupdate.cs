using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class Deliveryupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "OurRef",
                table: "PurchaseOrder",
                newName: "StockCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockCode",
                table: "PurchaseOrder",
                newName: "OurRef");

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
    }
}
