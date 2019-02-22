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
    public class employeesController : Controller
    {
        private readonly StoreSchedulerContext _context;

        public employeesController(StoreSchedulerContext context)
        {
            _context = context;
        }

        // GET: employees
        public async Task<IActionResult> Index()
        {
            var storeSchedulerContext = _context.employees.Include(e => e.role).Include(e => e.user);
            return View(await storeSchedulerContext.ToListAsync());
        }

        // GET: employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.employees
                .Include(e => e.role)
                .Include(e => e.user)
                .SingleOrDefaultAsync(m => m.employeeID == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // GET: employees/Create
        public IActionResult Create()
        {
            ViewData["roleID"] = new SelectList(_context.roles, "roleID", "roleID");
            ViewData["userID"] = new SelectList(_context.users, "userID", "userID");
            return View();
        }

        // POST: employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("employeeID,status,payType,hourlyRate,overtimeRate,userID,roleID")] employees employees)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["roleID"] = new SelectList(_context.roles, "roleID", "roleID", employees.roleID);
            ViewData["userID"] = new SelectList(_context.users, "userID", "userID", employees.userID);
            return View(employees);
        }

        // GET: employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.employees.SingleOrDefaultAsync(m => m.employeeID == id);
            if (employees == null)
            {
                return NotFound();
            }
            ViewData["roleID"] = new SelectList(_context.roles, "roleID", "roleID", employees.roleID);
            ViewData["userID"] = new SelectList(_context.users, "userID", "userID", employees.userID);
            return View(employees);
        }

        // POST: employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("employeeID,status,payType,hourlyRate,overtimeRate,userID,roleID")] employees employees)
        {
            if (id != employees.employeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!employeesExists(employees.employeeID))
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
            ViewData["roleID"] = new SelectList(_context.roles, "roleID", "roleID", employees.roleID);
            ViewData["userID"] = new SelectList(_context.users, "userID", "userID", employees.userID);
            return View(employees);
        }

        // GET: employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.employees
                .Include(e => e.role)
                .Include(e => e.user)
                .SingleOrDefaultAsync(m => m.employeeID == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employees = await _context.employees.SingleOrDefaultAsync(m => m.employeeID == id);
            _context.employees.Remove(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool employeesExists(int id)
        {
            return _context.employees.Any(e => e.employeeID == id);
        }
    }
}
