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
    public class ShopsController : Controller
    {
        private readonly SMContext _context;

        public ShopsController(SMContext context)
        {
            _context = context;
        }

        // GET: Shops
        public async Task<IActionResult> Index()
        {
            return View(await _context.Shop.ToListAsync());
        }

        // GET: Shops/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shop
                .SingleOrDefaultAsync(m => m.ShopRef == id);
            if (shops == null)
            {
                return NotFound();
            }

            return View(shops);
        }

        // GET: Shops/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShopRef,Shopname,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,Email,Memo,SHopType,CreatedBy,CreatedDate")] Shops shops)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shops);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shops);
        }

        // GET: Shops/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shop.SingleOrDefaultAsync(m => m.ShopRef == id);
            if (shops == null)
            {
                return NotFound();
            }
            return View(shops);
        }

        // POST: Shops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ShopRef,Shopname,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,Email,Memo,SHopType,CreatedBy,CreatedDate")] Shops shops)
        {
            if (id != shops.ShopRef)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shops);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopsExists(shops.ShopRef))
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
            return View(shops);
        }

        // GET: Shops/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shop
                .SingleOrDefaultAsync(m => m.ShopRef == id);
            if (shops == null)
            {
                return NotFound();
            }

            return View(shops);
        }

        // POST: Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var shops = await _context.Shop.SingleOrDefaultAsync(m => m.ShopRef == id);
            _context.Shop.Remove(shops);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopsExists(string id)
        {
            return _context.Shop.Any(e => e.ShopRef == id);
        }
    }
}
