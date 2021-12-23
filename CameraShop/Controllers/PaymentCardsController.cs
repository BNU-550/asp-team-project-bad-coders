﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CameraShop.Data;
using CameraShop.Models;

namespace CameraShop.Controllers
{
    public class PaymentCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PaymentCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.PaymentCards.ToListAsync());
        }

        // GET: PaymentCards/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.PaymentCards
                .FirstOrDefaultAsync(m => m.PaymentCardID == id);
            if (paymentCard == null)
            {
                return NotFound();
            }

            return View(paymentCard);
        }

        // GET: PaymentCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentCardID,CardName,ExpiryMonth,ExpiryYear,CvsNumber")] PaymentCard paymentCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentCard);
        }

        // GET: PaymentCards/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.PaymentCards.FindAsync(id);
            if (paymentCard == null)
            {
                return NotFound();
            }
            return View(paymentCard);
        }

        // POST: PaymentCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("PaymentCardID,CardName,ExpiryMonth,ExpiryYear,CvsNumber")] PaymentCard paymentCard)
        {
            if (id != paymentCard.PaymentCardID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentCardExists(paymentCard.PaymentCardID))
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
            return View(paymentCard);
        }

        // GET: PaymentCards/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.PaymentCards
                .FirstOrDefaultAsync(m => m.PaymentCardID == id);
            if (paymentCard == null)
            {
                return NotFound();
            }

            return View(paymentCard);
        }

        // POST: PaymentCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var paymentCard = await _context.PaymentCards.FindAsync(id);
            _context.PaymentCards.Remove(paymentCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentCardExists(long id)
        {
            return _context.PaymentCards.Any(e => e.PaymentCardID == id);
        }
    }
}
