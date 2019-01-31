using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockManager.Data.Data;
using StockManager.Data.Data.Entities;

namespace StockManager.UI.Controllers
{
    public class shopDeliveriesController : Controller
    {
        private readonly SMContext _context;

        public shopDeliveriesController(SMContext context)
        {
            _context = context;
        }

        // GET: shopDeliveries
        public async Task<IActionResult> Index(string SortOrder)
        {
            ViewBag.OurRefSortParm = String.IsNullOrEmpty(SortOrder) ? "OurRefDes" : "";
            ViewBag.SupplierRefSortParm = String.IsNullOrEmpty(SortOrder) ? "SPRefDes" : "SPRef";
            ViewBag.ShopRefSortParm = String.IsNullOrEmpty(SortOrder) ? "SHRefDes" : "SHRef";
            ViewBag.DeliveryDateSortParm = SortOrder == "Date" ? "date_desc" : "Date";
            var shopDeliveries= from s in _context.ShopDelivery
                                 select s;
            switch (SortOrder)
            {
                case "OurRefDes":
                    shopDeliveries = shopDeliveries.OrderByDescending(s => s.StockCode);
                    break;
                case "SPRefDes":
                    shopDeliveries = shopDeliveries.OrderByDescending(s => s.ShopRef);
                    break;
                case "SHRefDes":
                    shopDeliveries = shopDeliveries.OrderByDescending(s => s.ShopRef);
                    break;
                case "SPRef":
                    shopDeliveries = shopDeliveries.OrderBy(s => s.DeliveryRef);
                    break;
                case "WHRef":
                    shopDeliveries = shopDeliveries.OrderBy(s => s.WarehouseRef);
                    break;
                case "date_desc":
                    shopDeliveries = shopDeliveries.OrderByDescending(s => s.DeliveryDate);
                    break;
                case "Date":
                    shopDeliveries = shopDeliveries.OrderBy(s => s.DeliveryDate);
                    break;
                default:
                    shopDeliveries = shopDeliveries.OrderByDescending(s => s.ShopDeliveryID);
                    break;
            }
            return View(shopDeliveries.ToList());
            //return View(await _context.PurchaseOrder.ToListAsync());
        }
        // GET: shopDeliveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopDeliveries = await _context.ShopDelivery
                .SingleOrDefaultAsync(m => m.ShopDeliveryID == id);
            if (shopDeliveries == null)
            {
                return NotFound();
            }

            return View(shopDeliveries);
        }

        // GET: shopDeliveries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: shopDeliveries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShopDeliveryID,ShopRef,WarehouseRef,DeliveryRef,StockCode,QtyHangers,DeliveryDate,Notes,CreatedBy,CreatedDate")] shopDeliveries shopDeliveries)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopDeliveries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopDeliveries);
        }

        // GET: shopDeliveries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopDeliveries = await _context.ShopDelivery.SingleOrDefaultAsync(m => m.ShopDeliveryID == id);
            if (shopDeliveries == null)
            {
                return NotFound();
            }
            return View(shopDeliveries);
        }

        // POST: shopDeliveries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShopDeliveryID,ShopRef,WarehouseRef,DeliveryRef,StockCode,QtyHangers,DeliveryDate,Notes,CreatedBy,CreatedDate")] shopDeliveries shopDeliveries)
        {
            if (id != shopDeliveries.ShopDeliveryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopDeliveries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!shopDeliveriesExists(shopDeliveries.ShopDeliveryID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(shopDeliveries);
        }

        // GET: shopDeliveries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopDeliveries = await _context.ShopDelivery
                .SingleOrDefaultAsync(m => m.ShopDeliveryID == id);
            if (shopDeliveries == null)
            {
                return NotFound();
            }

            return View(shopDeliveries);
        }

        // POST: shopDeliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopDeliveries = await _context.ShopDelivery.SingleOrDefaultAsync(m => m.ShopDeliveryID == id);
            _context.ShopDelivery.Remove(shopDeliveries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool shopDeliveriesExists(int id)
        {
            return _context.ShopDelivery.Any(e => e.ShopDeliveryID == id);
        }
    }
}
