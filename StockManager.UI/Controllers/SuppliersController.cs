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
    public class SuppliersController : Controller
    {
        private readonly SMContext _context;

        public SuppliersController(SMContext context)
        {
            _context = context;
        }

        // GET: Suppliers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Supplier.ToListAsync());
        }

        // GET: Suppliers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliers = await _context.Supplier
                .SingleOrDefaultAsync(m => m.SupplierRef == id);
            if (suppliers == null)
            {
                return NotFound();
            }

            return View(suppliers);
        }

        // GET: Suppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierRef,SupplierName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,Email,Memo,CreatedBy,CreatedDate")] Suppliers suppliers)
        {
            if (ModelState.IsValid)
            {
                suppliers.CreatedBy = "Admin";
                suppliers.CreatedDate = DateTime.Now;
                _context.Add(suppliers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suppliers);
        }

        // GET: Suppliers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliers = await _context.Supplier.SingleOrDefaultAsync(m => m.SupplierRef == id);
            if (suppliers == null)
            {
                return NotFound();
            }
            return View(suppliers);
        }

        // POST: Suppliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SupplierRef,SupplierName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,Email,Memo")] Suppliers suppliers)
        {
            if (id != suppliers.SupplierRef)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suppliers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuppliersExists(suppliers.SupplierRef))
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
            return View(suppliers);
        }

        // GET: Suppliers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliers = await _context.Supplier
                .SingleOrDefaultAsync(m => m.SupplierRef == id);
            if (suppliers == null)
            {
                return NotFound();
            }

            return View(suppliers);
        }

        // POST: Suppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var suppliers = await _context.Supplier.SingleOrDefaultAsync(m => m.SupplierRef == id);
            _context.Supplier.Remove(suppliers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuppliersExists(string id)
        {
            return _context.Supplier.Any(e => e.SupplierRef == id);
        }
    }
}
