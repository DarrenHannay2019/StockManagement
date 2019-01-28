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
    public class shopReturnsController : Controller
    {
        private readonly SMContext _context;

        public shopReturnsController(SMContext context)
        {
            _context = context;
        }

        // GET: shopReturns
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShopReturn.ToListAsync());
        }

        // GET: shopReturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopReturns = await _context.ShopReturn
                .SingleOrDefaultAsync(m => m.ReturnID == id);
            if (shopReturns == null)
            {
                return NotFound();
            }

            return View(shopReturns);
        }

        // GET: shopReturns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: shopReturns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReturnID,ShopRef,WarehouseRef,Reference,TransactionDate,StockCode,QtyReturned,CreatedBy,CreatedDate")] shopReturns shopReturns)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopReturns);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopReturns);
        }

        // GET: shopReturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopReturns = await _context.ShopReturn.SingleOrDefaultAsync(m => m.ReturnID == id);
            if (shopReturns == null)
            {
                return NotFound();
            }
            return View(shopReturns);
        }

        // POST: shopReturns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReturnID,ShopRef,WarehouseRef,Reference,TransactionDate,StockCode,QtyReturned,CreatedBy,CreatedDate")] shopReturns shopReturns)
        {
            if (id != shopReturns.ReturnID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopReturns);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!shopReturnsExists(shopReturns.ReturnID))
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
            return View(shopReturns);
        }

        // GET: shopReturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopReturns = await _context.ShopReturn
                .SingleOrDefaultAsync(m => m.ReturnID == id);
            if (shopReturns == null)
            {
                return NotFound();
            }

            return View(shopReturns);
        }

        // POST: shopReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopReturns = await _context.ShopReturn.SingleOrDefaultAsync(m => m.ReturnID == id);
            _context.ShopReturn.Remove(shopReturns);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool shopReturnsExists(int id)
        {
            return _context.ShopReturn.Any(e => e.ReturnID == id);
        }
    }
}
