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
    public class WarehouseReturnsController : Controller
    {
        private readonly SMContext _context;

        public WarehouseReturnsController(SMContext context)
        {
            _context = context;
        }

        // GET: WarehouseReturns
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarehouseReturn.ToListAsync());
        }

        // GET: WarehouseReturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseReturn = await _context.WarehouseReturn
                .SingleOrDefaultAsync(m => m.WarehouseReturnID == id);
            if (warehouseReturn == null)
            {
                return NotFound();
            }

            return View(warehouseReturn);
        }

        // GET: WarehouseReturns/Create
        public IActionResult Create()
        {
            var items = _context.Warehouse.ToList();
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

        // POST: WarehouseReturns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WarehouseReturnID,Reference,ReturnDate,FromWarehouseRef,ToWarehouseRef,StockCode,TotalGarmentsQty,TotalBoxesQty,TotalUnitsQty,CreatedBy,CreatedDate")] WarehouseReturn warehouseReturn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(warehouseReturn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warehouseReturn);
        }

        // GET: WarehouseReturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseReturn = await _context.WarehouseReturn.SingleOrDefaultAsync(m => m.WarehouseReturnID == id);
            if (warehouseReturn == null)
            {
                return NotFound();
            }
            return View(warehouseReturn);
        }

        // POST: WarehouseReturns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WarehouseReturnID,Reference,ReturnDate,FromWarehouseRef,ToWarehouseRef,StockCode,TotalGarmentsQty,TotalBoxesQty,TotalUnitsQty,CreatedBy,CreatedDate")] WarehouseReturn warehouseReturn)
        {
            if (id != warehouseReturn.WarehouseReturnID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warehouseReturn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarehouseReturnExists(warehouseReturn.WarehouseReturnID))
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
            return View(warehouseReturn);
        }

        // GET: WarehouseReturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseReturn = await _context.WarehouseReturn
                .SingleOrDefaultAsync(m => m.WarehouseReturnID == id);
            if (warehouseReturn == null)
            {
                return NotFound();
            }

            return View(warehouseReturn);
        }

        // POST: WarehouseReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var warehouseReturn = await _context.WarehouseReturn.SingleOrDefaultAsync(m => m.WarehouseReturnID == id);
            _context.WarehouseReturn.Remove(warehouseReturn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarehouseReturnExists(int id)
        {
            return _context.WarehouseReturn.Any(e => e.WarehouseReturnID == id);
        }
       
    }

}
