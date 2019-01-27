using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StockManager.Data.Data.Entities;

namespace StockManager.Data.Data
{
    public class SMContext : IdentityDbContext<User>
    {
        public SMContext(DbContextOptions<SMContext> options) : base(options)
        {

        }
        public DbSet<StockManager.Data.Data.Entities.shopDeliveries> ShopDelivery { get; set; }
        public DbSet<StockManager.Data.Data.Entities.shopDeliveryLines> ShopDeliveryLine { get; set; }
        public DbSet<StockManager.Data.Data.Entities.WarehouseAdjustments> WarehouseAdjustment { get; set; }
        public DbSet<StockManager.Data.Data.Entities.WarehouseAdjustmentLines> WarehouseAdjustmentLines { get; set; }
        public DbSet<StockManager.Data.Data.Entities.shopAdjustments> ShopAdjustment { get; set; }
        public DbSet<StockManager.Data.Data.Entities.shopAdjustmentLine> ShopAdjustmentLines { get; set; }
        public DbSet<StockManager.Data.Data.Entities.Deliveries> PurchaseOrder { get; set; }
        public DbSet<StockManager.Data.Data.Entities.DelliveryLines> PurchaseOrderLines { get; set; }
        public DbSet<StockManager.Data.Data.Entities.shopTransferLines> ShopTransferLines { get; set; }
        public DbSet<StockManager.Data.Data.Entities.shopTransfers> ShopTransfer { get; set; }
        public DbSet<StockManager.Data.Data.Entities.shopReturnLines> ShopReturnLines { get; set; }
        public DbSet<StockManager.Data.Data.Entities.shopReturns> ShopReturn { get; set; }
        public DbSet<StockManager.Data.Data.Entities.WarehouseTransferLines> WarehouseTransferLines { get; set; }
        public DbSet<StockManager.Data.Data.Entities.WarehouseTransfers> WarehouseTransfer { get; set; }
        public DbSet<StockManager.Data.Data.Entities.WarehouseReturnLines> WarehouseReturnLines { get; set; }
        public DbSet<StockManager.Data.Data.Entities.WarehouseReturn> WarehouseReturn { get; set; }
        public DbSet<StockManager.Data.Data.Entities.Suppliers> Supplier { get; set; }
        public DbSet<StockManager.Data.Data.Entities.Settings> Settings { get; set; }
        public DbSet<StockManager.Data.Data.Entities.Warehouse> Warehouse { get; set; }
        public DbSet<StockManager.Data.Data.Entities.Shops> Shop { get; set; }
        public DbSet<StockManager.Data.Data.Entities.Stock> Stock { get; set; }
        public DbSet<StockManager.Data.Data.Entities.Seasons> Season { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
