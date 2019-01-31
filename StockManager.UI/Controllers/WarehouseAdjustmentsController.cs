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
        public async Task<IActionResult> Index(string SortOrder)
        {
            ViewBag.OurRefSortParm = String.IsNullOrEmpty(SortOrder) ? "OurRefDes" : "";
         
            ViewBag.WarehouseRefSortParm = String.IsNullOrEmpty(SortOrder) ? "WHRefDes" : "WHRef";
            ViewBag.DeliveryDateSortParm = SortOrder == "Date" ? "date_desc" : "Date";
            var warehouseAdjustments = from s in _context.WarehouseAdjustment
                                 select s;
            switch (SortOrder)
            {
                case "OurRefDes":
                    warehouseAdjustments = warehouseAdjustments.OrderByDescending(s => s.StockCode);
                    break;                
                case "WHRefDes":
                    warehouseAdjustments = warehouseAdjustments.OrderByDescending(s => s.WarehouseRef);
                    break;                
                case "WHRef":
                    warehouseAdjustments = warehouseAdjustments.OrderBy(s => s.WarehouseRef);
                    break;
                case "date_desc":
                    warehouseAdjustments = warehouseAdjustments.OrderByDescending(s => s.MovementDate);
                    break;
                case "Date":
                    warehouseAdjustments = warehouseAdjustments.OrderBy(s => s.MovementDate);
                    break;
                default:
                    warehouseAdjustments = warehouseAdjustments.OrderByDescending(s => s.WarehouseAdjustID);
                    break;
            }
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
            var StockItems = _context.Stock.ToList();
            if(items!=null)
            {
                ViewBag.data = items;               
            }
            if (StockItems != null)
            {
                 ViewBag.Stock = StockItems;
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
                warehouseAdjustments.CreatedBy = "Admin";
                warehouseAdjustments.CreatedDate = DateTime.Now;
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
            return View(warehouseAdjustments);
        }

        // POST: WarehouseAdjustments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WarehouseAdjustID,WarehouseRef,Reference,StockCode,MovementType,TotalItems,MovementDate")] WarehouseAdjustments warehouseAdjustments)
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
