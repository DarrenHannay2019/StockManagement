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
    public class PurchaseOrdersController : Controller
    {
        private readonly SMContext _context;

        public PurchaseOrdersController(SMContext context)
        {
            _context = context;
        }

        // GET: PurchaseOrders
        public async Task<IActionResult> Index(string SortOrder) 
        {
            ViewBag.OurRefSortParm = String.IsNullOrEmpty(SortOrder) ? "OurRefDes" : "";
            ViewBag.SupplierRefSortParm = String.IsNullOrEmpty(SortOrder) ? "SPRefDes" : "SPRef";
            ViewBag.WarehouseRefSortParm = String.IsNullOrEmpty(SortOrder) ? "WHRefDes" : "WHRef";
            ViewBag.DeliveryDateSortParm = SortOrder == "Date" ? "date_desc" : "Date";
            var PurchaseOrders = from s in _context.PurchaseOrder
                                 select s;
            switch (SortOrder)
            {
                case "OurRefDes":
                    PurchaseOrders = PurchaseOrders.OrderByDescending(s => s.StockCode);
                    break;
                case "SPRefDes":
                    PurchaseOrders = PurchaseOrders.OrderByDescending(s => s.SupplierRef);
                    break;
                case "WHRefDes":
                    PurchaseOrders = PurchaseOrders.OrderByDescending(s => s.WarehouseRef);
                    break;
                case "SPRef":
                    PurchaseOrders = PurchaseOrders.OrderBy(s => s.SupplierRef);
                    break;
                case "WHRef":
                    PurchaseOrders = PurchaseOrders.OrderBy(s => s.WarehouseRef);
                    break;
                case "date_desc":
                    PurchaseOrders = PurchaseOrders.OrderByDescending(s => s.DeliveryDate);
                    break;
                case "Date":
                    PurchaseOrders = PurchaseOrders.OrderBy(s => s.DeliveryDate);
                    break;
                default:
                    PurchaseOrders = PurchaseOrders.OrderByDescending(s => s.DeliveryID);
                    break;
            }
            return View(await _context.PurchaseOrder.ToListAsync());
        }

        // GET: PurchaseOrders/Details/5
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

        // GET: PurchaseOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeliveryID,StockCode,SupplierRef,WarehouseRef,Season,TotalGarments,TotalHangers,TotalBoxes,NetAmount,DeliveryCharge,Commission,VATAmount,GrossAmount,DeliveryDate,Notes,Invoice,Shipper,ShipperInvoice,CreatedBy,CreatedDate")] Deliveries deliveries)
        {
            if (ModelState.IsValid)
            {
                deliveries.CreatedBy = "Admin";
                deliveries.CreatedDate = DateTime.Now;
                _context.Add(deliveries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveries);
        }

        // GET: PurchaseOrders/Edit/5
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

        // POST: PurchaseOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeliveryID,StockCode,SupplierRef,WarehouseRef,Season,TotalGarments,TotalHangers,TotalBoxes,NetAmount,DeliveryCharge,Commission,VATAmount,GrossAmount,DeliveryDate,Notes,Invoice,Shipper,ShipperInvoice,CreatedBy,CreatedDate")] Deliveries deliveries)
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

        // GET: PurchaseOrders/Delete/5
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

        // POST: PurchaseOrders/Delete/5
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
