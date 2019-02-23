using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Store_Scheduler.Data;
using Store_Scheduler.Models;

namespace Store_Scheduler.Controllers
{
    public class storesController : Controller
    {
        private readonly StoreSchedulerContext _context;

        public storesController(StoreSchedulerContext context)
        {
            _context = context;
        }

        // GET: stores
        public async Task<IActionResult> Index()
        {
            return View(await _context.stores.ToListAsync());
        }

        // GET: stores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stores = await _context.stores
                .SingleOrDefaultAsync(m => m.storeID == id);
            if (stores == null)
            {
                return NotFound();
            }

            return View(stores);
        }

        // GET: stores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: stores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("storeID,storeName,address,city,state,zipcode,phone")] stores stores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stores);
        }

        // GET: stores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stores = await _context.stores.SingleOrDefaultAsync(m => m.storeID == id);
            if (stores == null)
            {
                return NotFound();
            }
            return View(stores);
        }

        // POST: stores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("storeID,storeName,address,city,state,zipcode,phone")] stores stores)
        {
            if (id != stores.storeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!storesExists(stores.storeID))
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
            return View(stores);
        }

        // GET: stores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stores = await _context.stores
                .SingleOrDefaultAsync(m => m.storeID == id);
            if (stores == null)
            {
                return NotFound();
            }

            return View(stores);
        }

        // POST: stores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stores = await _context.stores.SingleOrDefaultAsync(m => m.storeID == id);
            _context.stores.Remove(stores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool storesExists(int id)
        {
            return _context.stores.Any(e => e.storeID == id);
        }
    }
}
