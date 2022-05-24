using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_School.Data;
using MVC_School.Models;

namespace MVC_School.Controllers
{
    public class StudentenController : Controller
    {
        private readonly SchoolDbContext _context;

        public StudentenController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Studenten
        public async Task<IActionResult> Index()
        {
              return _context.Studenten != null ? 
                          View(await _context.Studenten.ToListAsync()) :
                          Problem("Entity set 'SchoolDbContext.Studenten'  is null.");
        }

        // GET: Studenten/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Studenten == null)
            {
                return NotFound();
            }

            var student = await _context.Studenten
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Studenten/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studenten/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Voornaam,Achternaam,Adres,Woonplaats")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Studenten/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Studenten == null)
            {
                return NotFound();
            }

            var student = await _context.Studenten.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Studenten/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Voornaam,Achternaam,Adres,Woonplaats")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            return View(student);
        }

        // GET: Studenten/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Studenten == null)
            {
                return NotFound();
            }

            var student = await _context.Studenten
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Studenten/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Studenten == null)
            {
                return Problem("Entity set 'SchoolDbContext.Studenten'  is null.");
            }
            var student = await _context.Studenten.FindAsync(id);
            if (student != null)
            {
                _context.Studenten.Remove(student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
          return (_context.Studenten?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
