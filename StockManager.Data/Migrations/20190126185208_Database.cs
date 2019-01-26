using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    DeliveryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Commission = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeliveryCharge = table.Column<double>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    GrossAmount = table.Column<double>(nullable: false),
                    Invoice = table.Column<string>(nullable: true),
                    NetAmount = table.Column<double>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OurRef = table.Column<string>(maxLength: 30, nullable: true),
                    Season = table.Column<string>(maxLength: 50, nullable: true),
                    Shipper = table.Column<string>(maxLength: 50, nullable: true),
                    ShipperInvoice = table.Column<string>(nullable: true),
                    SupplierRef = table.Column<string>(maxLength: 8, nullable: true),
                    TotalBoxes = table.Column<int>(nullable: false),
                    TotalGarments = table.Column<int>(nullable: false),
                    TotalHangers = table.Column<int>(nullable: false),
                    VATAmount = table.Column<double>(nullable: false),
                    WarehouseRef = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.DeliveryID);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderLines",
                columns: table => new
                {
                    DeliveryLinesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryID = table.Column<int>(nullable: false),
                    NetAmount = table.Column<double>(nullable: false),
                    QtyBoxes = table.Column<int>(nullable: false),
                    QtyGarments = table.Column<int>(nullable: false),
                    QtyHangers = table.Column<int>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderLines", x => x.DeliveryLinesID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(maxLength: 50, nullable: true),
                    Address2 = table.Column<string>(maxLength: 50, nullable: true),
                    Address3 = table.Column<string>(maxLength: 50, nullable: true),
                    Address4 = table.Column<string>(maxLength: 50, nullable: true),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    PostCode = table.Column<string>(maxLength: 12, nullable: true),
                    Season = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(maxLength: 18, nullable: true),
                    VATReg = table.Column<string>(maxLength: 50, nullable: true),
                    VatRate = table.Column<decimal>(nullable: false),
                    WWW = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ShopRef = table.Column<string>(maxLength: 8, nullable: false),
                    Address1 = table.Column<string>(maxLength: 60, nullable: true),
                    Address2 = table.Column<string>(maxLength: 60, nullable: true),
                    Address3 = table.Column<string>(maxLength: 60, nullable: true),
                    Address4 = table.Column<string>(maxLength: 60, nullable: true),
                    ContactName = table.Column<string>(maxLength: 60, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Fax = table.Column<string>(maxLength: 60, nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(maxLength: 60, nullable: true),
                    SHopType = table.Column<int>(maxLength: 60, nullable: true),
                    Shopname = table.Column<string>(maxLength: 60, nullable: true),
                    Telephone = table.Column<string>(maxLength: 60, nullable: true),
                    Telephone2 = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ShopRef);
                });

            migrationBuilder.CreateTable(
                name: "ShopAdjustment",
                columns: table => new
                {
                    ShopAdjustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    MovementDate = table.Column<DateTime>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    ShopRef = table.Column<string>(maxLength: 8, nullable: true),
                    TotalGainItems = table.Column<int>(nullable: false),
                    TotalLossItems = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopAdjustment", x => x.ShopAdjustID);
                });

            migrationBuilder.CreateTable(
                name: "ShopAdjustmentLines",
                columns: table => new
                {
                    ShopAdjustmentLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovementType = table.Column<string>(maxLength: 50, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    ShopAdjustmentsID = table.Column<int>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 30, nullable: true),
                    Values = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopAdjustmentLines", x => x.ShopAdjustmentLineID);
                });

            migrationBuilder.CreateTable(
                name: "ShopDelivery",
                columns: table => new
                {
                    ShopDeliveryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    DeliveryRef = table.Column<string>(maxLength: 50, nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ShopRef = table.Column<string>(maxLength: 8, nullable: false),
                    TotHangers = table.Column<int>(nullable: false),
                    WarehouseRef = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopDelivery", x => x.ShopDeliveryID);
                });

            migrationBuilder.CreateTable(
                name: "ShopDeliveryLine",
                columns: table => new
                {
                    DeliveryLinesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QtyHangers = table.Column<int>(nullable: false),
                    ShopDeliveryID = table.Column<int>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopDeliveryLine", x => x.DeliveryLinesID);
                });

            migrationBuilder.CreateTable(
                name: "ShopReturn",
                columns: table => new
                {
                    ReturnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    QtyReturned = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    ShopRef = table.Column<string>(maxLength: 8, nullable: true),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    WarehouseRef = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopReturn", x => x.ReturnID);
                });

            migrationBuilder.CreateTable(
                name: "ShopReturnLines",
                columns: table => new
                {
                    ReturnLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Qty = table.Column<int>(nullable: false),
                    ReturnID = table.Column<int>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 30, nullable: true),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopReturnLines", x => x.ReturnLineID);
                });

            migrationBuilder.CreateTable(
                name: "ShopTransfer",
                columns: table => new
                {
                    ShopTransferID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FromShopRef = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    ToShopRef = table.Column<string>(nullable: true),
                    TotalQtyIn = table.Column<int>(nullable: false),
                    TotalQtyOut = table.Column<int>(nullable: false),
                    TransferDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopTransfer", x => x.ShopTransferID);
                });

            migrationBuilder.CreateTable(
                name: "ShopTransferLines",
                columns: table => new
                {
                    TransferLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentQty = table.Column<int>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 30, nullable: true),
                    TIQty = table.Column<int>(nullable: false),
                    TOQty = table.Column<int>(nullable: false),
                    TransferID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopTransferLines", x => x.TransferLineID);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockCode = table.Column<string>(maxLength: 30, nullable: false),
                    AmtTakes = table.Column<double>(nullable: false),
                    CostVal = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeadCode = table.Column<bool>(nullable: false),
                    DeliveredQtyHangers = table.Column<int>(nullable: false),
                    Season = table.Column<string>(maxLength: 60, nullable: true),
                    SupplierRef = table.Column<string>(maxLength: 8, nullable: true),
                    ZeroQty = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockCode);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierRef = table.Column<string>(maxLength: 8, nullable: false),
                    Address1 = table.Column<string>(maxLength: 60, nullable: true),
                    Address2 = table.Column<string>(maxLength: 60, nullable: true),
                    Address3 = table.Column<string>(maxLength: 60, nullable: true),
                    Address4 = table.Column<string>(maxLength: 60, nullable: true),
                    ContactName = table.Column<string>(maxLength: 60, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Fax = table.Column<string>(maxLength: 60, nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(maxLength: 60, nullable: true),
                    SupplierName = table.Column<string>(maxLength: 60, nullable: true),
                    Telephone = table.Column<string>(maxLength: 60, nullable: true),
                    Telephone2 = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierRef);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    WarehouseRef = table.Column<string>(maxLength: 8, nullable: false),
                    Address1 = table.Column<string>(maxLength: 60, nullable: true),
                    Address2 = table.Column<string>(maxLength: 60, nullable: true),
                    Address3 = table.Column<string>(maxLength: 60, nullable: true),
                    Address4 = table.Column<string>(maxLength: 60, nullable: true),
                    ContactName = table.Column<string>(maxLength: 60, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Default = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Fax = table.Column<string>(maxLength: 60, nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(maxLength: 60, nullable: true),
                    Telephone = table.Column<string>(maxLength: 60, nullable: true),
                    Telephone2 = table.Column<string>(maxLength: 60, nullable: true),
                    WarehouseName = table.Column<string>(maxLength: 60, nullable: true),
                    WarehouseType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.WarehouseRef);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseAdjustment",
                columns: table => new
                {
                    WarehouseAdjustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    MovementDate = table.Column<DateTime>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    TotalGainItems = table.Column<int>(nullable: false),
                    TotalLossItems = table.Column<int>(nullable: false),
                    WarehouseRef = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseAdjustment", x => x.WarehouseAdjustID);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseAdjustmentLines",
                columns: table => new
                {
                    WarehouseAdjustmentLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovementType = table.Column<string>(maxLength: 50, nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 30, nullable: true),
                    Values = table.Column<double>(nullable: false),
                    WarehouseAdjustmentsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseAdjustmentLines", x => x.WarehouseAdjustmentLineID);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseReturn",
                columns: table => new
                {
                    WarehouseReturnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FromWarehouseRef = table.Column<string>(maxLength: 8, nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    ToWarehouseRef = table.Column<string>(maxLength: 8, nullable: true),
                    TotalBoxesQty = table.Column<int>(nullable: false),
                    TotalGarmentsQty = table.Column<int>(nullable: false),
                    TotalUnitsQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseReturn", x => x.WarehouseReturnID);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseReturnLines",
                columns: table => new
                {
                    WarehouseReturnLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentQtyBoxes = table.Column<int>(nullable: false),
                    CurrentQtyGarments = table.Column<int>(nullable: false),
                    CurrentQtyUnits = table.Column<int>(nullable: false),
                    ReturnID = table.Column<int>(nullable: false),
                    ReturnQtyBoxes = table.Column<int>(nullable: false),
                    ReturnQtyGarments = table.Column<int>(nullable: false),
                    ReturnQtyUnits = table.Column<int>(nullable: false),
                    StockCode = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseReturnLines", x => x.WarehouseReturnLineID);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseTransfer",
                columns: table => new
                {
                    WarehouseTransferID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 16, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FromWarehouseRef = table.Column<string>(maxLength: 8, nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    ToWarehouseRef = table.Column<string>(maxLength: 8, nullable: true),
                    TotalBoxesQtyIn = table.Column<int>(nullable: false),
                    TotalBoxesQtyOut = table.Column<int>(nullable: false),
                    TotalGarmentsQtyIn = table.Column<int>(nullable: false),
                    TotalGarmentsQtyOut = table.Column<int>(nullable: false),
                    TotalUnitsQtyIn = table.Column<int>(nullable: false),
                    TotalUnitsQtyOut = table.Column<int>(nullable: false),
                    TransferDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseTransfer", x => x.WarehouseTransferID);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseTransferLines",
                columns: table => new
                {
                    WarehouseTransferLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockCode = table.Column<string>(maxLength: 30, nullable: true),
                    TOQtyBoxes = table.Column<int>(nullable: false),
                    TOQtyGarments = table.Column<int>(nullable: false),
                    TOQtyUnits = table.Column<int>(nullable: false),
                    WarehouseTransferID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseTransferLines", x => x.WarehouseTransferLineID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "PurchaseOrderLines");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "ShopAdjustment");

            migrationBuilder.DropTable(
                name: "ShopAdjustmentLines");

            migrationBuilder.DropTable(
                name: "ShopDelivery");

            migrationBuilder.DropTable(
                name: "ShopDeliveryLine");

            migrationBuilder.DropTable(
                name: "ShopReturn");

            migrationBuilder.DropTable(
                name: "ShopReturnLines");

            migrationBuilder.DropTable(
                name: "ShopTransfer");

            migrationBuilder.DropTable(
                name: "ShopTransferLines");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "WarehouseAdjustment");

            migrationBuilder.DropTable(
                name: "WarehouseAdjustmentLines");

            migrationBuilder.DropTable(
                name: "WarehouseReturn");

            migrationBuilder.DropTable(
                name: "WarehouseReturnLines");

            migrationBuilder.DropTable(
                name: "WarehouseTransfer");

            migrationBuilder.DropTable(
                name: "WarehouseTransferLines");
        }
    }
}
