using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class RedesignOfDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalBoxesQtyIn",
                table: "WarehouseTransfer");

            migrationBuilder.DropColumn(
                name: "TotalGarmentsQtyIn",
                table: "WarehouseTransfer");

            migrationBuilder.DropColumn(
                name: "TotalUnitsQtyIn",
                table: "WarehouseTransfer");

            migrationBuilder.DropColumn(
                name: "TotalGainItems",
                table: "WarehouseAdjustment");

            migrationBuilder.DropColumn(
                name: "TotalQtyIn",
                table: "ShopTransfer");

            migrationBuilder.RenameColumn(
                name: "TotalLossItems",
                table: "WarehouseAdjustment",
                newName: "TotalItems");

            migrationBuilder.RenameColumn(
                name: "TotHangers",
                table: "ShopDelivery",
                newName: "QtyHangers");

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "WarehouseTransfer",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "WarehouseReturn",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovementType",
                table: "WarehouseAdjustment",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "WarehouseAdjustment",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "ShopTransfer",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "ShopReturn",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "ShopDelivery",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovementType",
                table: "ShopAdjustment",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "ShopAdjustment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "ShopAdjustment",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Values",
                table: "ShopAdjustment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "WarehouseTransfer");

            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "WarehouseReturn");

            migrationBuilder.DropColumn(
                name: "MovementType",
                table: "WarehouseAdjustment");

            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "WarehouseAdjustment");

            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "ShopTransfer");

            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "ShopReturn");

            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "ShopDelivery");

            migrationBuilder.DropColumn(
                name: "MovementType",
                table: "ShopAdjustment");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "ShopAdjustment");

            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "ShopAdjustment");

            migrationBuilder.DropColumn(
                name: "Values",
                table: "ShopAdjustment");

            migrationBuilder.RenameColumn(
                name: "TotalItems",
                table: "WarehouseAdjustment",
                newName: "TotalLossItems");

            migrationBuilder.RenameColumn(
                name: "QtyHangers",
                table: "ShopDelivery",
                newName: "TotHangers");

            migrationBuilder.AddColumn<int>(
                name: "TotalBoxesQtyIn",
                table: "WarehouseTransfer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalGarmentsQtyIn",
                table: "WarehouseTransfer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUnitsQtyIn",
                table: "WarehouseTransfer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalGainItems",
                table: "WarehouseAdjustment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalQtyIn",
                table: "ShopTransfer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
