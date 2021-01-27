using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Reduntant_Medicine_Donation_portal.Data;
using Reduntant_Medicine_Donation_portal.Models;

namespace Reduntant_Medicine_Donation_portal.Controllers
{
    public class AllDonatedMedicinesController : Controller
    {
        private readonly AppDbContext _context;

        public AllDonatedMedicinesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AllDonatedMedicines
        public async Task<IActionResult> Index()
        {
            return View(await _context.AllDonatedMedicines.ToListAsync());
        }

        // GET: AllDonatedMedicines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allDonatedMedicine = await _context.AllDonatedMedicines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (allDonatedMedicine == null)
            {
                return NotFound();
            }

            return View(allDonatedMedicine);
        }

        // GET: AllDonatedMedicines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AllDonatedMedicines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ExpireDate,Quantity,DonarId")] AllDonatedMedicine allDonatedMedicine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allDonatedMedicine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(allDonatedMedicine);
        }

        // GET: AllDonatedMedicines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allDonatedMedicine = await _context.AllDonatedMedicines.FindAsync(id);
            if (allDonatedMedicine == null)
            {
                return NotFound();
            }
            return View(allDonatedMedicine);
        }

        // POST: AllDonatedMedicines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ExpireDate,Quantity,DonarId")] AllDonatedMedicine allDonatedMedicine)
        {
            if (id != allDonatedMedicine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allDonatedMedicine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllDonatedMedicineExists(allDonatedMedicine.Id))
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
            return View(allDonatedMedicine);
        }

        // GET: AllDonatedMedicines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allDonatedMedicine = await _context.AllDonatedMedicines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (allDonatedMedicine == null)
            {
                return NotFound();
            }

            return View(allDonatedMedicine);
        }

        // POST: AllDonatedMedicines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var allDonatedMedicine = await _context.AllDonatedMedicines.FindAsync(id);
            _context.AllDonatedMedicines.Remove(allDonatedMedicine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllDonatedMedicineExists(int id)
        {
            return _context.AllDonatedMedicines.Any(e => e.Id == id);
        }
    }
}
