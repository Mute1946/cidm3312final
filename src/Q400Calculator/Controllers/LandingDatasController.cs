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
    public class LandingDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LandingDatasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: LandingDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.LandingData.ToListAsync());
        }

        // GET: LandingDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landingData = await _context.LandingData.SingleOrDefaultAsync(m => m.Id == id);
            if (landingData == null)
            {
                return NotFound();
            }

            return View(landingData);
        }

        // GET: LandingDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LandingDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Flaps,Vapp,Vga,Vref,Weight")] LandingData landingData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landingData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(landingData);
        }

        // GET: LandingDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landingData = await _context.LandingData.SingleOrDefaultAsync(m => m.Id == id);
            if (landingData == null)
            {
                return NotFound();
            }
            return View(landingData);
        }

        // POST: LandingDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Flaps,Vapp,Vga,Vref,Weight")] LandingData landingData)
        {
            if (id != landingData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landingData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LandingDataExists(landingData.Id))
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
            return View(landingData);
        }

        // GET: LandingDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landingData = await _context.LandingData.SingleOrDefaultAsync(m => m.Id == id);
            if (landingData == null)
            {
                return NotFound();
            }

            return View(landingData);
        }

        // POST: LandingDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landingData = await _context.LandingData.SingleOrDefaultAsync(m => m.Id == id);
            _context.LandingData.Remove(landingData);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool LandingDataExists(int id)
        {
            return _context.LandingData.Any(e => e.Id == id);
        }
    }
}
