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
    public class shopTransfersController : Controller
    {
        private readonly SMContext _context;

        public shopTransfersController(SMContext context)
        {
            _context = context;
        }

        // GET: shopTransfers
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShopTransfer.ToListAsync());
        }

        // GET: shopTransfers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopTransfers = await _context.ShopTransfer
                .SingleOrDefaultAsync(m => m.ShopTransferID == id);
            if (shopTransfers == null)
            {
                return NotFound();
            }

            return View(shopTransfers);
        }

        // GET: shopTransfers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: shopTransfers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShopTransferID,Reference,TransferDate,FromShopRef,ToShopRef,StockCode,TotalQtyOut,CreatedBy,CreatedDate")] shopTransfers shopTransfers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopTransfers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopTransfers);
        }

        // GET: shopTransfers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopTransfers = await _context.ShopTransfer.SingleOrDefaultAsync(m => m.ShopTransferID == id);
            if (shopTransfers == null)
            {
                return NotFound();
            }
            return View(shopTransfers);
        }

        // POST: shopTransfers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShopTransferID,Reference,TransferDate,FromShopRef,ToShopRef,StockCode,TotalQtyOut,CreatedBy,CreatedDate")] shopTransfers shopTransfers)
        {
            if (id != shopTransfers.ShopTransferID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopTransfers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!shopTransfersExists(shopTransfers.ShopTransferID))
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
            return View(shopTransfers);
        }

        // GET: shopTransfers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopTransfers = await _context.ShopTransfer
                .SingleOrDefaultAsync(m => m.ShopTransferID == id);
            if (shopTransfers == null)
            {
                return NotFound();
            }

            return View(shopTransfers);
        }

        // POST: shopTransfers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopTransfers = await _context.ShopTransfer.SingleOrDefaultAsync(m => m.ShopTransferID == id);
            _context.ShopTransfer.Remove(shopTransfers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool shopTransfersExists(int id)
        {
            return _context.ShopTransfer.Any(e => e.ShopTransferID == id);
        }
    }
}
