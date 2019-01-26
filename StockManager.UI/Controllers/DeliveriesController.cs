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
    public class DeliveriesController : Controller
    {
        private readonly SMContext _context;

        public DeliveriesController(SMContext context)
        {
            _context = context;
        }

        // GET: Deliveries
        public async Task<IActionResult> Index()
        {
            return View(await _context.PurchaseOrder.ToListAsync());
        }

        // GET: Deliveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveries = await _context.PurchaseOrder
                .SingleOrDefaultAsync(m => m.DeliveryID == id);
            if (deliveries == null)
            {
                return NotFound();
            }

            return View(deliveries);
        }

        // GET: Deliveries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Deliveries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeliveryID,OurRef,SupplierRef,WarehouseRef,Season,TotalGarments,TotalHangers,TotalBoxes,NetAmount,DeliveryCharge,Commission,VATAmount,GrossAmount,DeliveryDate,Notes,Invoice,Shipper,ShipperInvoice,CreatedBy,CreatedDate")] Deliveries deliveries)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveries);
        }

        // GET: Deliveries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveries = await _context.PurchaseOrder.SingleOrDefaultAsync(m => m.DeliveryID == id);
            if (deliveries == null)
            {
                return NotFound();
            }
            return View(deliveries);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeliveryID,OurRef,SupplierRef,WarehouseRef,Season,TotalGarments,TotalHangers,TotalBoxes,NetAmount,DeliveryCharge,Commission,VATAmount,GrossAmount,DeliveryDate,Notes,Invoice,Shipper,ShipperInvoice,CreatedBy,CreatedDate")] Deliveries deliveries)
        {
            if (id != deliveries.DeliveryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveriesExists(deliveries.DeliveryID))
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
            return View(deliveries);
        }

        // GET: Deliveries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveries = await _context.PurchaseOrder
                .SingleOrDefaultAsync(m => m.DeliveryID == id);
            if (deliveries == null)
            {
                return NotFound();
            }

            return View(deliveries);
        }

        // POST: Deliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveries = await _context.PurchaseOrder.SingleOrDefaultAsync(m => m.DeliveryID == id);
            _context.PurchaseOrder.Remove(deliveries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveriesExists(int id)
        {
            return _context.PurchaseOrder.Any(e => e.DeliveryID == id);
        }
    }
}
