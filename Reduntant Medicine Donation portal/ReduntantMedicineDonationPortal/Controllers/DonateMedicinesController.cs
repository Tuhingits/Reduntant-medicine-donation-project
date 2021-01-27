using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Reduntant_Medicine_Donation_portal.Data;
using Reduntant_Medicine_Donation_portal.Models;

namespace Reduntant_Medicine_Donation_portal.Controllers
{
    [Authorize(Roles = "Donor")]
    public class DonateMedicinesController : Controller
    {
        
        private readonly AppDbContext _context;

        public DonateMedicinesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DonateMedicines
        public async Task<IActionResult> Index()
        {
            return View(await _context.DonateMedicines.ToListAsync());
        }

        // GET: DonateMedicines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateMedicine = await _context.DonateMedicines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donateMedicine == null)
            {
                return NotFound();
            }

            return View(donateMedicine);
        }

        // GET: DonateMedicines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DonateMedicines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ExpireDate,Quantity,DonarId,OrgId")] DonateMedicine donateMedicine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donateMedicine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donateMedicine);
        }

        // GET: DonateMedicines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateMedicine = await _context.DonateMedicines.FindAsync(id);
            if (donateMedicine == null)
            {
                return NotFound();
            }
            return View(donateMedicine);
        }

        // POST: DonateMedicines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ExpireDate,Quantity,DonarId,OrgId")] DonateMedicine donateMedicine)
        {
            if (id != donateMedicine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donateMedicine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonateMedicineExists(donateMedicine.Id))
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
            return View(donateMedicine);
        }

        // GET: DonateMedicines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateMedicine = await _context.DonateMedicines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donateMedicine == null)
            {
                return NotFound();
            }

            return View(donateMedicine);
        }

        // POST: DonateMedicines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donateMedicine = await _context.DonateMedicines.FindAsync(id);
            _context.DonateMedicines.Remove(donateMedicine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonateMedicineExists(int id)
        {
            return _context.DonateMedicines.Any(e => e.Id == id);
        }
    }
}
