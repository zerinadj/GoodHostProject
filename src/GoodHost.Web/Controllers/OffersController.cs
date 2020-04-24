using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekat_1.Data;
using Projekat_1.Models;

namespace Projekat_1.Controllers
{
    public class OffersController : Controller
    {
        private readonly Projekat_1Context _context;

        public OffersController(Projekat_1Context context)
        {
            _context = context;
        }

        // GET: Offers
        public async Task<IActionResult> Index()
        {
            var projekat_1Context = _context.Offers.Include(o => o.Place).Include(o => o.Rent).Include(o => o.UserRole);
            return View(await projekat_1Context.ToListAsync());
        }

        // GET: Offers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offers
                .Include(o => o.Place)
                .Include(o => o.Rent)
                .Include(o => o.UserRole)
                .FirstOrDefaultAsync(m => m.IdOffer == id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // GET: Offers/Create
        public IActionResult Create()
        {
            ViewData["PlaceId"] = new SelectList(_context.Places, "IdPlace", "IdPlace");
            ViewData["RentId"] = new SelectList(_context.Rents, "IdRent", "IdRent");
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "IdURole", "IdURole");
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdOffer,PlaceId,RentId,UserRoleId,Date")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(offer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlaceId"] = new SelectList(_context.Places, "IdPlace", "IdPlace", offer.PlaceId);
            ViewData["RentId"] = new SelectList(_context.Rents, "IdRent", "IdRent", offer.RentId);
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "IdURole", "IdURole", offer.UserRoleId);
            return View(offer);
        }

        // GET: Offers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offers.FindAsync(id);
            if (offer == null)
            {
                return NotFound();
            }
            ViewData["PlaceId"] = new SelectList(_context.Places, "IdPlace", "IdPlace", offer.PlaceId);
            ViewData["RentId"] = new SelectList(_context.Rents, "IdRent", "IdRent", offer.RentId);
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "IdURole", "IdURole", offer.UserRoleId);
            return View(offer);
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdOffer,PlaceId,RentId,UserRoleId,Date")] Offer offer)
        {
            if (id != offer.IdOffer)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfferExists(offer.IdOffer))
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
            ViewData["PlaceId"] = new SelectList(_context.Places, "IdPlace", "IdPlace", offer.PlaceId);
            ViewData["RentId"] = new SelectList(_context.Rents, "IdRent", "IdRent", offer.RentId);
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "IdURole", "IdURole", offer.UserRoleId);
            return View(offer);
        }

        // GET: Offers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offers
                .Include(o => o.Place)
                .Include(o => o.Rent)
                .Include(o => o.UserRole)
                .FirstOrDefaultAsync(m => m.IdOffer == id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offer = await _context.Offers.FindAsync(id);
            _context.Offers.Remove(offer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfferExists(int id)
        {
            return _context.Offers.Any(e => e.IdOffer == id);
        }
    }
}
