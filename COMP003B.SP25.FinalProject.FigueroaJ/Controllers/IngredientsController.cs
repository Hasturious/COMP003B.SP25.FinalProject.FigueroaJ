using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP003B.SP25.FinalProject.FigueroaJ.Models;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Controllers
{
    public class IngredientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IngredientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ingredients
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ingredients.Include(i => i.Recipe);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Ingredients/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredient = await _context.Ingredients
                .Include(i => i.Recipe)
                .FirstOrDefaultAsync(m => m.IngredientId == id);
            if (ingredient == null)
            {
                return NotFound();
            }

            return View(ingredient);
        }

        // GET: Ingredients/Create
        public IActionResult Create()
        {
            ViewBag.RecipeId = new SelectList(_context.Recipes, "RecipeId", "RecipeTitle");
            return View();
        }

        // POST: Ingredients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IngredientId,Name,Quantity,RecipeId")] Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingredient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.RecipeId = new SelectList(_context.Recipes, "RecipeId", "RecipeTitle", ingredient.RecipeId);
            return View(ingredient);
        }

        // GET: Ingredients/Edit/
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredient = await _context.Ingredients.FindAsync(id);
            if (ingredient == null)
            {
                return NotFound();
            }
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "RecipeId", "RecipeId", ingredient.RecipeId);
            return View(ingredient);
        }

        // POST: Ingredients/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IngredientId,Name,Quantity,RecipeId")] Ingredient ingredient)
        {
            if (id != ingredient.IngredientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingredient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngredientExists(ingredient.IngredientId))
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
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "RecipeId", "RecipeId", ingredient.RecipeId);
            return View(ingredient);
        }

        // GET: Ingredients/Delete/
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredient = await _context.Ingredients
                .Include(i => i.Recipe)
                .FirstOrDefaultAsync(m => m.IngredientId == id);
            if (ingredient == null)
            {
                return NotFound();
            }

            return View(ingredient);
        }

        // POST: Ingredients/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingredient = await _context.Ingredients.FindAsync(id);
            if (ingredient != null)
            {
                _context.Ingredients.Remove(ingredient);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngredientExists(int id)
        {
            return _context.Ingredients.Any(e => e.IngredientId == id);
        }
    }
}
