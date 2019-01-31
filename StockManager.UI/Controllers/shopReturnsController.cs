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
        public async Task<IActionResult> Index(string SortOrder)
        {
            ViewBag.OurRefSortParm = String.IsNullOrEmpty(SortOrder) ? "OurRefDes" : "";
            ViewBag.ShopRefSortParm = String.IsNullOrEmpty(SortOrder) ? "SHRefDes" : "SHRef";
            ViewBag.DeliveryDateSortParm = SortOrder == "Date" ? "date_desc" : "Date";
            var returnOrders = from s in _context.ShopReturn
                                 select s;
            switch (SortOrder)
            {
                case "OurRefDes":
                    returnOrders = returnOrders.OrderByDescending(s => s.StockCode);
                    break;
                case "SHRefDes":
                    returnOrders = returnOrders.OrderByDescending(s => s.ShopRef);
                    break;
                case "SHRef":
                    returnOrders = returnOrders.OrderBy(s => s.ShopRef);
                    break;
                case "date_desc":
                    returnOrders = returnOrders.OrderByDescending(s => s.TransactionDate);
                    break;
                case "Date":
                    returnOrders = returnOrders.OrderBy(s => s.TransactionDate);
                    break;
                default:
                    returnOrders = returnOrders.OrderByDescending(s => s.ReturnID);
                    break;
            }
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
            var items = _context.Shop.ToList();
            var StockItems = _context.Stock.ToList();
            var toitems = _context.Warehouse.ToList();
            if(toitems != null)
            {
                ViewBag.Warehouse = toitems;
            }
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
            var items = _context.Shop.ToList();
            var StockItems = _context.Stock.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }
            if (StockItems != null)
            {
                ViewBag.Stock = StockItems;
            }
            var shopReturn = await _context.ShopReturn.SingleOrDefaultAsync(m => m.ReturnID == id);
            if (shopReturn == null)
            {
                return NotFound();
            }
            return View(shopReturn);
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
