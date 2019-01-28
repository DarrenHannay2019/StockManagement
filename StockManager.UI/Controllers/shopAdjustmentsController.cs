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
        public async Task<IActionResult> Index()
        {
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
