using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Data;
using Q400Calculator.Models;

namespace Q400Calculator.Controllers
{
    public class ClimbDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClimbDatasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ClimbDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClimbData.ToListAsync());
        }

        // GET: ClimbDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var climbData = await _context.ClimbData.SingleOrDefaultAsync(m => m.Id == id);
            if (climbData == null)
            {
                return NotFound();
            }

            return View(climbData);
        }

        // GET: ClimbDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClimbDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vclmb,Vfri10,Vfri15,Vfri5,Vref,Weight")] ClimbData climbData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(climbData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(climbData);
        }

        // GET: ClimbDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var climbData = await _context.ClimbData.SingleOrDefaultAsync(m => m.Id == id);
            if (climbData == null)
            {
                return NotFound();
            }
            return View(climbData);
        }

        // POST: ClimbDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vclmb,Vfri10,Vfri15,Vfri5,Vref,Weight")] ClimbData climbData)
        {
            if (id != climbData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(climbData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClimbDataExists(climbData.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(climbData);
        }

        // GET: ClimbDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var climbData = await _context.ClimbData.SingleOrDefaultAsync(m => m.Id == id);
            if (climbData == null)
            {
                return NotFound();
            }

            return View(climbData);
        }

        // POST: ClimbDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var climbData = await _context.ClimbData.SingleOrDefaultAsync(m => m.Id == id);
            _context.ClimbData.Remove(climbData);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ClimbDataExists(int id)
        {
            return _context.ClimbData.Any(e => e.Id == id);
        }
    }
}
