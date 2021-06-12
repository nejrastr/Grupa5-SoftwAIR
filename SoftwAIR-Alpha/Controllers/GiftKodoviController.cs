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
    public class GiftKodoviController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GiftKodoviController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GiftKodovi
        public async Task<IActionResult> Index()
        {
            return View(await _context.GiftKod.ToListAsync());
        }

        // GET: GiftKodovi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giftKod = await _context.GiftKod
                .FirstOrDefaultAsync(m => m.id == id);
            if (giftKod == null)
            {
                return NotFound();
            }

            return View(giftKod);
        }

        // GET: GiftKodovi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GiftKodovi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,kod,trenutniStatus")] GiftKod giftKod)
        {
            if (ModelState.IsValid)
            {
                _context.Add(giftKod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(giftKod);
        }

        // GET: GiftKodovi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giftKod = await _context.GiftKod.FindAsync(id);
            if (giftKod == null)
            {
                return NotFound();
            }
            return View(giftKod);
        }

        // POST: GiftKodovi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,kod,trenutniStatus")] GiftKod giftKod)
        {
            if (id != giftKod.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(giftKod);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiftKodExists(giftKod.id))
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
            return View(giftKod);
        }

        // GET: GiftKodovi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giftKod = await _context.GiftKod
                .FirstOrDefaultAsync(m => m.id == id);
            if (giftKod == null)
            {
                return NotFound();
            }

            return View(giftKod);
        }

        // POST: GiftKodovi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var giftKod = await _context.GiftKod.FindAsync(id);
            _context.GiftKod.Remove(giftKod);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiftKodExists(int id)
        {
            return _context.GiftKod.Any(e => e.id == id);
        }
    }
}
