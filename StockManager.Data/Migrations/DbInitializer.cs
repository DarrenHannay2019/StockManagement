using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockManager.Data.Data;
using StockManager.Data.Data.Entities;

namespace StockManager.Data.Migrations
{
    public class DbInitializer
    {
        public static void RecreateDatabase(SMContext sMContext)
        {
            sMContext.Database.EnsureDeleted();
            sMContext.Database.EnsureCreatedAsync();
        }
        public static void Initialize(SMContext sMContext)
        {
            if(!sMContext.Warehouse.Any())
            {
                var warehouses = new List<Warehouse>
                {
                    new Warehouse
                    {
                        WarehouseRef = "UNI",
                        WarehouseName = "Universal Warehouse",
                        WarehouseType = Warehouse.WHType.Active,
                        CreatedBy ="Bob",
                        CreatedDate = DateTime.Now
                        
                    },
                    new Warehouse
                    {
                        WarehouseRef = "WOFF",
                        WarehouseName = "Waste Warehouse",
                        WarehouseType = Warehouse.WHType.Waste
                    },
                    new Warehouse
                    {
                        WarehouseRef = "LONG",
                        WarehouseName = "Long-Term Warehouse",
                        WarehouseType = Warehouse.WHType.Long,
                        CreatedBy ="Bob",
                        CreatedDate = DateTime.Now
                    }
                };
                sMContext.Warehouse.AddRange(warehouses);
                sMContext.SaveChangesAsync();
            }
            if(!sMContext.Supplier.Any())
            {
                var suppliers = new List<Suppliers>
                {
                    new Suppliers
                    {
                        SupplierRef = "ABC",
                        SupplierName = "A B C Designs"
                    },
                    new Suppliers
                    {
                        SupplierRef = "MISC",
                        SupplierName = "Misc Designs"
                    }
                };
            }
            if(!sMContext.Shop.Any())
            {
                var shops = new List<Shops>
                {
                    new Shops
                    {
                        ShopRef ="BO",
                        Shopname = "Bognor",
                        SHopType = Shops.SHType.Shop
                    },
                    new Shops
                    {
                        ShopRef = "DU",
                        Shopname = "Dummy Shop",
                        SHopType = Shops.SHType.Shop
                    },
                    new Shops
                    {
                        ShopRef = "HW",
                        Shopname = "High Wycombe",
                        SHopType = Shops.SHType.Consessions
                    }
                };
            }
        }
    }
}
