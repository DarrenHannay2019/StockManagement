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
    public class WarehouseAdjustmentsController : Controller
    {
        private readonly SMContext _context;

        public WarehouseAdjustmentsController(SMContext context)
        {
            _context = context;
        }

        // GET: WarehouseAdjustments
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarehouseAdjustment.ToListAsync());
        }

        // GET: WarehouseAdjustments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseAdjustments = await _context.WarehouseAdjustment
                .SingleOrDefaultAsync(m => m.WarehouseAdjustID == id);
            if (warehouseAdjustments == null)
            {
                return NotFound();
            }

            return View(warehouseAdjustments);
        }

        // GET: WarehouseAdjustments/Create
        public IActionResult Create()
        {
            var items = _context.Warehouse.ToList();
            if(items!=null)
            {
                ViewBag.data = items;
            }
            return View();
        }

        // POST: WarehouseAdjustments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WarehouseAdjustID,WarehouseRef,Reference,StockCode,MovementType,TotalItems,MovementDate,CreatedBy,CreatedDate")] WarehouseAdjustments warehouseAdjustments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(warehouseAdjustments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warehouseAdjustments);
        }

        // GET: WarehouseAdjustments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseAdjustments = await _context.WarehouseAdjustment.SingleOrDefaultAsync(m => m.WarehouseAdjustID == id);
            if (warehouseAdjustments == null)
            {
                return NotFound();
            }
            return View(warehouseAdjustments);
        }

        // POST: WarehouseAdjustments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WarehouseAdjustID,WarehouseRef,Reference,StockCode,MovementType,TotalItems,MovementDate,CreatedBy,CreatedDate")] WarehouseAdjustments warehouseAdjustments)
        {
            if (id != warehouseAdjustments.WarehouseAdjustID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warehouseAdjustments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarehouseAdjustmentsExists(warehouseAdjustments.WarehouseAdjustID))
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
            return View(warehouseAdjustments);
        }

        // GET: WarehouseAdjustments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseAdjustments = await _context.WarehouseAdjustment
                .SingleOrDefaultAsync(m => m.WarehouseAdjustID == id);
            if (warehouseAdjustments == null)
            {
                return NotFound();
            }

            return View(warehouseAdjustments);
        }

        // POST: WarehouseAdjustments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var warehouseAdjustments = await _context.WarehouseAdjustment.SingleOrDefaultAsync(m => m.WarehouseAdjustID == id);
            _context.WarehouseAdjustment.Remove(warehouseAdjustments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarehouseAdjustmentsExists(int id)
        {
            return _context.WarehouseAdjustment.Any(e => e.WarehouseAdjustID == id);
        }
    }
}
