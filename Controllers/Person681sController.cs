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
    public class Person681sController : Controller
    {
        private readonly AplicationContext _context;

        public Person681sController(AplicationContext context)
        {
            _context = context;
        }

        // GET: Person681s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonTTL681.ToListAsync());
        }

        // GET: Person681s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTTL681 = await _context.PersonTTL681
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personTTL681 == null)
            {
                return NotFound();
            }

            return View(personTTL681);
        }

        // GET: Person681s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Person681s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonTTL681 personTTL681)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personTTL681);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personTTL681);
        }

        // GET: Person681s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTTL681 = await _context.PersonTTL681.FindAsync(id);
            if (personTTL681 == null)
            {
                return NotFound();
            }
            return View(personTTL681);
        }

        // POST: Person681s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonTTL681 personTTL681)
        {
            if (id != personTTL681.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personTTL681);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonTTL681Exists(personTTL681.PersonId))
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
            return View(personTTL681);
        }

        // GET: Person681s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTTL681 = await _context.PersonTTL681
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personTTL681 == null)
            {
                return NotFound();
            }

            return View(personTTL681);
        }

        // POST: Person681s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personTTL681 = await _context.PersonTTL681.FindAsync(id);
            _context.PersonTTL681.Remove(personTTL681);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonTTL681Exists(string id)
        {
            return _context.PersonTTL681.Any(e => e.PersonId == id);
        }
    }
}
