using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class comboboxdropdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveriesDeliveryID",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseReturnID",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseTransfersWarehouseTransferID",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopDeliveriesShopDeliveryID",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopReturnsReturnID",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveriesDeliveryID",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveriesDeliveryID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseAdjustmentsWarehouseAdjustID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseReturnID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseTransfersWarehouseTransferID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopAdjustmentsShopAdjustID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopDeliveriesShopDeliveryID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopReturnsReturnID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopTransfersShopTransferID",
                table: "Stock",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopAdjustmentsShopAdjustID",
                table: "Shop",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopDeliveriesShopDeliveryID",
                table: "Shop",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopReturnsReturnID",
                table: "Shop",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shopTransfersShopTransferID",
                table: "Shop",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_DeliveriesDeliveryID",
                table: "Warehouse",
                column: "DeliveriesDeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_WarehouseReturnID",
                table: "Warehouse",
                column: "WarehouseReturnID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_WarehouseTransfersWarehouseTransferID",
                table: "Warehouse",
                column: "WarehouseTransfersWarehouseTransferID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_shopDeliveriesShopDeliveryID",
                table: "Warehouse",
                column: "shopDeliveriesShopDeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_shopReturnsReturnID",
                table: "Warehouse",
                column: "shopReturnsReturnID");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_DeliveriesDeliveryID",
                table: "Supplier",
                column: "DeliveriesDeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_DeliveriesDeliveryID",
                table: "Stock",
                column: "DeliveriesDeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Stock",
                column: "WarehouseAdjustmentsWarehouseAdjustID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_WarehouseReturnID",
                table: "Stock",
                column: "WarehouseReturnID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_WarehouseTransfersWarehouseTransferID",
                table: "Stock",
                column: "WarehouseTransfersWarehouseTransferID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_shopAdjustmentsShopAdjustID",
                table: "Stock",
                column: "shopAdjustmentsShopAdjustID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_shopDeliveriesShopDeliveryID",
                table: "Stock",
                column: "shopDeliveriesShopDeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_shopReturnsReturnID",
                table: "Stock",
                column: "shopReturnsReturnID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_shopTransfersShopTransferID",
                table: "Stock",
                column: "shopTransfersShopTransferID");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_shopAdjustmentsShopAdjustID",
                table: "Shop",
                column: "shopAdjustmentsShopAdjustID");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_shopDeliveriesShopDeliveryID",
                table: "Shop",
                column: "shopDeliveriesShopDeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_shopReturnsReturnID",
                table: "Shop",
                column: "shopReturnsReturnID");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_shopTransfersShopTransferID",
                table: "Shop",
                column: "shopTransfersShopTransferID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_ShopAdjustment_shopAdjustmentsShopAdjustID",
                table: "Shop",
                column: "shopAdjustmentsShopAdjustID",
                principalTable: "ShopAdjustment",
                principalColumn: "ShopAdjustID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_ShopDelivery_shopDeliveriesShopDeliveryID",
                table: "Shop",
                column: "shopDeliveriesShopDeliveryID",
                principalTable: "ShopDelivery",
                principalColumn: "ShopDeliveryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_ShopReturn_shopReturnsReturnID",
                table: "Shop",
                column: "shopReturnsReturnID",
                principalTable: "ShopReturn",
                principalColumn: "ReturnID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_ShopTransfer_shopTransfersShopTransferID",
                table: "Shop",
                column: "shopTransfersShopTransferID",
                principalTable: "ShopTransfer",
                principalColumn: "ShopTransferID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_PurchaseOrder_DeliveriesDeliveryID",
                table: "Stock",
                column: "DeliveriesDeliveryID",
                principalTable: "PurchaseOrder",
                principalColumn: "DeliveryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_WarehouseAdjustment_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Stock",
                column: "WarehouseAdjustmentsWarehouseAdjustID",
                principalTable: "WarehouseAdjustment",
                principalColumn: "WarehouseAdjustID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_WarehouseReturn_WarehouseReturnID",
                table: "Stock",
                column: "WarehouseReturnID",
                principalTable: "WarehouseReturn",
                principalColumn: "WarehouseReturnID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_WarehouseTransfer_WarehouseTransfersWarehouseTransferID",
                table: "Stock",
                column: "WarehouseTransfersWarehouseTransferID",
                principalTable: "WarehouseTransfer",
                principalColumn: "WarehouseTransferID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_ShopAdjustment_shopAdjustmentsShopAdjustID",
                table: "Stock",
                column: "shopAdjustmentsShopAdjustID",
                principalTable: "ShopAdjustment",
                principalColumn: "ShopAdjustID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_ShopDelivery_shopDeliveriesShopDeliveryID",
                table: "Stock",
                column: "shopDeliveriesShopDeliveryID",
                principalTable: "ShopDelivery",
                principalColumn: "ShopDeliveryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_ShopReturn_shopReturnsReturnID",
                table: "Stock",
                column: "shopReturnsReturnID",
                principalTable: "ShopReturn",
                principalColumn: "ReturnID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_ShopTransfer_shopTransfersShopTransferID",
                table: "Stock",
                column: "shopTransfersShopTransferID",
                principalTable: "ShopTransfer",
                principalColumn: "ShopTransferID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_PurchaseOrder_DeliveriesDeliveryID",
                table: "Supplier",
                column: "DeliveriesDeliveryID",
                principalTable: "PurchaseOrder",
                principalColumn: "DeliveryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_PurchaseOrder_DeliveriesDeliveryID",
                table: "Warehouse",
                column: "DeliveriesDeliveryID",
                principalTable: "PurchaseOrder",
                principalColumn: "DeliveryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_WarehouseReturn_WarehouseReturnID",
                table: "Warehouse",
                column: "WarehouseReturnID",
                principalTable: "WarehouseReturn",
                principalColumn: "WarehouseReturnID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_WarehouseTransfer_WarehouseTransfersWarehouseTransferID",
                table: "Warehouse",
                column: "WarehouseTransfersWarehouseTransferID",
                principalTable: "WarehouseTransfer",
                principalColumn: "WarehouseTransferID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_ShopDelivery_shopDeliveriesShopDeliveryID",
                table: "Warehouse",
                column: "shopDeliveriesShopDeliveryID",
                principalTable: "ShopDelivery",
                principalColumn: "ShopDeliveryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_ShopReturn_shopReturnsReturnID",
                table: "Warehouse",
                column: "shopReturnsReturnID",
                principalTable: "ShopReturn",
                principalColumn: "ReturnID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_ShopAdjustment_shopAdjustmentsShopAdjustID",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_ShopDelivery_shopDeliveriesShopDeliveryID",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_ShopReturn_shopReturnsReturnID",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_ShopTransfer_shopTransfersShopTransferID",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_PurchaseOrder_DeliveriesDeliveryID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_WarehouseAdjustment_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_WarehouseReturn_WarehouseReturnID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_WarehouseTransfer_WarehouseTransfersWarehouseTransferID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_ShopAdjustment_shopAdjustmentsShopAdjustID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_ShopDelivery_shopDeliveriesShopDeliveryID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_ShopReturn_shopReturnsReturnID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_ShopTransfer_shopTransfersShopTransferID",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_PurchaseOrder_DeliveriesDeliveryID",
                table: "Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_PurchaseOrder_DeliveriesDeliveryID",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_WarehouseReturn_WarehouseReturnID",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_WarehouseTransfer_WarehouseTransfersWarehouseTransferID",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_ShopDelivery_shopDeliveriesShopDeliveryID",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_ShopReturn_shopReturnsReturnID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_DeliveriesDeliveryID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_WarehouseReturnID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_WarehouseTransfersWarehouseTransferID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_shopDeliveriesShopDeliveryID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_shopReturnsReturnID",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_DeliveriesDeliveryID",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Stock_DeliveriesDeliveryID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_WarehouseAdjustmentsWarehouseAdjustID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_WarehouseReturnID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_WarehouseTransfersWarehouseTransferID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_shopAdjustmentsShopAdjustID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_shopDeliveriesShopDeliveryID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_shopReturnsReturnID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_shopTransfersShopTransferID",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Shop_shopAdjustmentsShopAdjustID",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_shopDeliveriesShopDeliveryID",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_shopReturnsReturnID",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_shopTransfersShopTransferID",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "DeliveriesDeliveryID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "WarehouseReturnID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "WarehouseTransfersWarehouseTransferID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "shopDeliveriesShopDeliveryID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "shopReturnsReturnID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "DeliveriesDeliveryID",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "DeliveriesDeliveryID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "WarehouseAdjustmentsWarehouseAdjustID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "WarehouseReturnID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "WarehouseTransfersWarehouseTransferID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "shopAdjustmentsShopAdjustID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "shopDeliveriesShopDeliveryID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "shopReturnsReturnID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "shopTransfersShopTransferID",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "shopAdjustmentsShopAdjustID",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "shopDeliveriesShopDeliveryID",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "shopReturnsReturnID",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "shopTransfersShopTransferID",
                table: "Shop");
        }
    }
}
