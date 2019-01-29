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
    public class WarehouseTransfersController : Controller
    {
        private readonly SMContext _context;

        public WarehouseTransfersController(SMContext context)
        {
            _context = context;
        }

        // GET: WarehouseTransfers
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarehouseTransfer.ToListAsync());
        }

        // GET: WarehouseTransfers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseTransfers = await _context.WarehouseTransfer
                .SingleOrDefaultAsync(m => m.WarehouseTransferID == id);
            if (warehouseTransfers == null)
            {
                return NotFound();
            }

            return View(warehouseTransfers);
        }

        // GET: WarehouseTransfers/Create
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

        // POST: WarehouseTransfers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WarehouseTransferID,Reference,TransferDate,FromWarehouseRef,ToWarehouseRef,StockCode,TotalGarmentsQtyOut,TotalBoxesQtyOut,TotalUnitsQtyOut,CreatedBy,CreatedDate")] WarehouseTransfers warehouseTransfers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(warehouseTransfers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warehouseTransfers);
        }

        // GET: WarehouseTransfers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseTransfers = await _context.WarehouseTransfer.SingleOrDefaultAsync(m => m.WarehouseTransferID == id);
            if (warehouseTransfers == null)
            {
                return NotFound();
            }
            return View(warehouseTransfers);
        }

        // POST: WarehouseTransfers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WarehouseTransferID,Reference,TransferDate,FromWarehouseRef,ToWarehouseRef,StockCode,TotalGarmentsQtyOut,TotalBoxesQtyOut,TotalUnitsQtyOut,CreatedBy,CreatedDate")] WarehouseTransfers warehouseTransfers)
        {
            if (id != warehouseTransfers.WarehouseTransferID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warehouseTransfers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarehouseTransfersExists(warehouseTransfers.WarehouseTransferID))
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
            return View(warehouseTransfers);
        }

        // GET: WarehouseTransfers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseTransfers = await _context.WarehouseTransfer
                .SingleOrDefaultAsync(m => m.WarehouseTransferID == id);
            if (warehouseTransfers == null)
            {
                return NotFound();
            }

            return View(warehouseTransfers);
        }

        // POST: WarehouseTransfers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var warehouseTransfers = await _context.WarehouseTransfer.SingleOrDefaultAsync(m => m.WarehouseTransferID == id);
            _context.WarehouseTransfer.Remove(warehouseTransfers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarehouseTransfersExists(int id)
        {
            return _context.WarehouseTransfer.Any(e => e.WarehouseTransferID == id);
        }
    }
}
