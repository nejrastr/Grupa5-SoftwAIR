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
    public class LetoviController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LetoviController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Letovi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Let.ToListAsync());
        }

        // GET: Letovi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @let = await _context.Let
                .FirstOrDefaultAsync(m => m.ID == id);
            if (@let == null)
            {
                return NotFound();
            }

            return View(@let);
        }

        // GET: Letovi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Letovi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,vrijemePolaska,vrijemeDolaska,osnovnaCijena,naPopustuZaLoyalty,statusLeta")] Let @let)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@let);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@let);
        }

        // GET: Letovi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @let = await _context.Let.FindAsync(id);
            if (@let == null)
            {
                return NotFound();
            }
            return View(@let);
        }

        // POST: Letovi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,vrijemePolaska,vrijemeDolaska,osnovnaCijena,naPopustuZaLoyalty,statusLeta")] Let @let)
        {
            if (id != @let.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@let);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LetExists(@let.ID))
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
            return View(@let);
        }

        // GET: Letovi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @let = await _context.Let
                .FirstOrDefaultAsync(m => m.ID == id);
            if (@let == null)
            {
                return NotFound();
            }

            return View(@let);
        }

        // POST: Letovi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @let = await _context.Let.FindAsync(id);
            _context.Let.Remove(@let);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LetExists(int id)
        {
            return _context.Let.Any(e => e.ID == id);
        }
    }
}
