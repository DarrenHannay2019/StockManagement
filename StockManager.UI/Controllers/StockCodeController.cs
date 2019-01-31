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
    public class StockCodeController : Controller
    {
        private readonly SMContext _context;

        public StockCodeController(SMContext context)
        {
            _context = context;
        }

        // GET: StockCode
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stock.ToListAsync());
        }

        // GET: StockCode/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stock
                .SingleOrDefaultAsync(m => m.StockCode == id);
            if (stock == null)
            {
                return NotFound();
            }

            return View(stock);
        }

        // GET: StockCode/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockCode/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockCode,SupplierRef,Season,DeadCode,AmtTakes,DeliveredQtyHangers,CostVal,ZeroQty,CreatedBy,CreatedDate")] Stock stock)
        {
            if (ModelState.IsValid)
            {
                stock.CreatedBy = "Admin";
                stock.CreatedDate = DateTime.Now;
                _context.Add(stock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stock);
        }

        // GET: StockCode/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stock.SingleOrDefaultAsync(m => m.StockCode == id);
            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);
        }

        // POST: StockCode/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StockCode,SupplierRef,Season,DeadCode,AmtTakes,DeliveredQtyHangers,CostVal,ZeroQty")] Stock stock)
        {
            if (id != stock.StockCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockExists(stock.StockCode))
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
            return View(stock);
        }

        // GET: StockCode/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stock
                .SingleOrDefaultAsync(m => m.StockCode == id);
            if (stock == null)
            {
                return NotFound();
            }

            return View(stock);
        }

        // POST: StockCode/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var stock = await _context.Stock.SingleOrDefaultAsync(m => m.StockCode == id);
            _context.Stock.Remove(stock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockExists(string id)
        {
            return _context.Stock.Any(e => e.StockCode == id);
        }
    }
}
