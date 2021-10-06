using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranThiLua681.Models;

namespace TranThiLua681.Controllers
{
    public class TTL681sController : Controller
    {
        private readonly AplicationContext _context;

        public TTL681sController(AplicationContext context)
        {
            _context = context;
        }

        // GET: TTL681s
        public async Task<IActionResult> Index()
        {
            return View(await _context.TTL681.ToListAsync());
        }

        // GET: TTL681s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTL681 = await _context.TTL681
                .FirstOrDefaultAsync(m => m.TLLId == id);
            if (tTL681 == null)
            {
                return NotFound();
            }

            return View(tTL681);
        }

        // GET: TTL681s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TTL681s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TLLId,TTLName,TTLGender")] TTL681 tTL681)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tTL681);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tTL681);
        }

        // GET: TTL681s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTL681 = await _context.TTL681.FindAsync(id);
            if (tTL681 == null)
            {
                return NotFound();
            }
            return View(tTL681);
        }

        // POST: TTL681s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TLLId,TTLName,TTLGender")] TTL681 tTL681)
        {
            if (id != tTL681.TLLId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tTL681);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TTL681Exists(tTL681.TLLId))
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
            return View(tTL681);
        }

        // GET: TTL681s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTL681 = await _context.TTL681
                .FirstOrDefaultAsync(m => m.TLLId == id);
            if (tTL681 == null)
            {
                return NotFound();
            }

            return View(tTL681);
        }

        // POST: TTL681s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tTL681 = await _context.TTL681.FindAsync(id);
            _context.TTL681.Remove(tTL681);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TTL681Exists(int id)
        {
            return _context.TTL681.Any(e => e.TLLId == id);
        }
    }
}
