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
    public class shopAdjustmentsController : Controller
    {
        private readonly SMContext _context;

        public shopAdjustmentsController(SMContext context)
        {
            _context = context;
        }

        // GET: shopAdjustments
        public async Task<IActionResult> Index(string SortOrder)
        {
            ViewBag.OurRefSortParm = String.IsNullOrEmpty(SortOrder) ? "OurRefDes" : "";

            ViewBag.ShopRefSortParm = String.IsNullOrEmpty(SortOrder) ? "SHRefDes" : "SHRef";
            ViewBag.DeliveryDateSortParm = SortOrder == "Date" ? "date_desc" : "Date";
            var shopAdjustments = from s in _context.ShopAdjustment
                                       select s;
            switch (SortOrder)
            {
                case "OurRefDes":
                    shopAdjustments = shopAdjustments.OrderByDescending(s => s.StockCode);
                    break;
                case "SHRefDes":
                    shopAdjustments = shopAdjustments.OrderByDescending(s => s.ShopRef);
                    break;
                case "SHRef":
                    shopAdjustments = shopAdjustments.OrderBy(s => s.ShopRef);
                    break;
                case "date_desc":
                    shopAdjustments = shopAdjustments.OrderByDescending(s => s.MovementDate);
                    break;
                case "Date":
                    shopAdjustments = shopAdjustments.OrderBy(s => s.MovementDate);
                    break;
                default:
                    shopAdjustments = shopAdjustments.OrderByDescending(s => s.ShopAdjustID);
                    break;
            }
            return View(await _context.ShopAdjustment.ToListAsync());
        }

        // GET: shopAdjustments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopAdjustments = await _context.ShopAdjustment
                .SingleOrDefaultAsync(m => m.ShopAdjustID == id);
            if (shopAdjustments == null)
            {
                return NotFound();
            }

            return View(shopAdjustments);
        }

        // GET: shopAdjustments/Create
        public IActionResult Create()
        {
            var items = _context.Shop.ToList();
            var StockItems = _context.Stock.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }
            if (StockItems != null)
            {
                ViewBag.Stock = StockItems;
            }
            return View();
        }

        // POST: shopAdjustments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShopAdjustID,ShopRef,Reference,TotalLossItems,TotalGainItems,MovementDate,StockCode,MovementType,Qty,Values,CreatedBy,CreatedDate")] shopAdjustments shopAdjustments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopAdjustments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopAdjustments);
        }

        // GET: shopAdjustments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopAdjustments = await _context.ShopAdjustment.SingleOrDefaultAsync(m => m.ShopAdjustID == id);
            if (shopAdjustments == null)
            {
                return NotFound();
            }
            var items = _context.Shop.ToList();
            var StockItems = _context.Stock.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }
            if (StockItems != null)
            {
                ViewBag.Stock = StockItems;
            }
            return View(shopAdjustments);
        }

        // POST: shopAdjustments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShopAdjustID,ShopRef,Reference,TotalLossItems,TotalGainItems,MovementDate,StockCode,MovementType,Qty,Values,CreatedBy,CreatedDate")] shopAdjustments shopAdjustments)
        {
            if (id != shopAdjustments.ShopAdjustID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopAdjustments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!shopAdjustmentsExists(shopAdjustments.ShopAdjustID))
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
            return View(shopAdjustments);
        }

        // GET: shopAdjustments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopAdjustments = await _context.ShopAdjustment
                .SingleOrDefaultAsync(m => m.ShopAdjustID == id);
            if (shopAdjustments == null)
            {
                return NotFound();
            }

            return View(shopAdjustments);
        }

        // POST: shopAdjustments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopAdjustments = await _context.ShopAdjustment.SingleOrDefaultAsync(m => m.ShopAdjustID == id);
            _context.ShopAdjustment.Remove(shopAdjustments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool shopAdjustmentsExists(int id)
        {
            return _context.ShopAdjustment.Any(e => e.ShopAdjustID == id);
        }
    }
}
