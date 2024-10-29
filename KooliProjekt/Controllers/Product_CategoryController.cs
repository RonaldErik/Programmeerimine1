using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Data;

namespace KooliProjekt.Controllers
{
    public class Product_CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Product_CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Product_Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.Category.ToListAsync());
        }

        // GET: Product_Category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Category = await _context.Category
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Category == null)
            {
                return NotFound();
            }

            return View(product_Category);
        }

        // GET: Product_Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product_Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cat_Name")] Product_Category product_Category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_Category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product_Category);
        }

        // GET: Product_Category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Category = await _context.Category.FindAsync(id);
            if (product_Category == null)
            {
                return NotFound();
            }
            return View(product_Category);
        }

        // POST: Product_Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cat_Name")] Product_Category product_Category)
        {
            if (id != product_Category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_Category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_CategoryExists(product_Category.Id))
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
            return View(product_Category);
        }

        // GET: Product_Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Category = await _context.Category
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Category == null)
            {
                return NotFound();
            }

            return View(product_Category);
        }

        // POST: Product_Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product_Category = await _context.Category.FindAsync(id);
            if (product_Category != null)
            {
                _context.Category.Remove(product_Category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product_CategoryExists(int id)
        {
            return _context.Category.Any(e => e.Id == id);
        }
    }
}
