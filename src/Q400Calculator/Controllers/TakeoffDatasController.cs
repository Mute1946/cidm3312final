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
    public class TakeoffDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TakeoffDatasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: TakeoffDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TakeoffData.ToListAsync());
        }

        // GET: TakeoffDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeoffData = await _context.TakeoffData.SingleOrDefaultAsync(m => m.Id == id);
            if (takeoffData == null)
            {
                return NotFound();
            }

            return View(takeoffData);
        }

        // GET: TakeoffDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TakeoffDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Above20,Altitude,Flaps,V2,Vr,Weight")] TakeoffData takeoffData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(takeoffData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(takeoffData);
        }

        // GET: TakeoffDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeoffData = await _context.TakeoffData.SingleOrDefaultAsync(m => m.Id == id);
            if (takeoffData == null)
            {
                return NotFound();
            }
            return View(takeoffData);
        }

        // POST: TakeoffDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Above20,Altitude,Flaps,V2,Vr,Weight")] TakeoffData takeoffData)
        {
            if (id != takeoffData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takeoffData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakeoffDataExists(takeoffData.Id))
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
            return View(takeoffData);
        }

        // GET: TakeoffDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeoffData = await _context.TakeoffData.SingleOrDefaultAsync(m => m.Id == id);
            if (takeoffData == null)
            {
                return NotFound();
            }

            return View(takeoffData);
        }

        // POST: TakeoffDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var takeoffData = await _context.TakeoffData.SingleOrDefaultAsync(m => m.Id == id);
            _context.TakeoffData.Remove(takeoffData);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TakeoffDataExists(int id)
        {
            return _context.TakeoffData.Any(e => e.Id == id);
        }
    }
}
