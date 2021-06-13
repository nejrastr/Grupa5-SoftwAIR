using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoftwAIR_Alpha.Data;
using SoftwAIR_Alpha.Models;

namespace SoftwAIR_Alpha.Controllers
{
    public class KartaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KartaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Karta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Karta.ToListAsync());
        }

        // GET: Karta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var karta = await _context.Karta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (karta == null)
            {
                return NotFound();
            }

            return View(karta);
        }

        // GET: Karta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Karta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,klasa,cijena")] Karta karta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(karta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(karta);
        }

        // GET: Karta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var karta = await _context.Karta.FindAsync(id);
            if (karta == null)
            {
                return NotFound();
            }
            return View(karta);
        }

        // POST: Karta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,klasa,cijena")] Karta karta)
        {
            if (id != karta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(karta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KartaExists(karta.ID))
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
            return View(karta);
        }

        // GET: Karta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var karta = await _context.Karta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (karta == null)
            {
                return NotFound();
            }

            return View(karta);
        }

        // POST: Karta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var karta = await _context.Karta.FindAsync(id);
            _context.Karta.Remove(karta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KartaExists(int id)
        {
            return _context.Karta.Any(e => e.ID == id);
        }
    }
}
