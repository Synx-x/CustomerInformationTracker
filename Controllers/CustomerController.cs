﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CustomerInformationTracker.Infrastructure;
using CustomerInformationTracker.Infrastructure.Models;
using CustomerInformationTracker.Services;
using CustomerInformationTracker.Interfaces;

namespace CustomerInformationTracker.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDBContext _context;
        private readonly ICustomerService _service;

        public CustomerController(CustomerDBContext context, ICustomerService service)
        {
            _context = context;
            _service = service;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            var customer = await _service.GetAllCustomersAsync();
            
            return View(customer);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound();

            var customer = await _service.GetCustomerByIdAsync(id);

            if (customer == null) return NotFound();

            return View(customer);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,TelephoneNumber,ContactPersonName,ContactPersonEmailAddress,VATNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {

                await _service.CreateCustomerAsync(customer);

                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null) return NotFound();

            var customer = await _service.GetCustomerByIdAsync(id);

            if (customer == null) return NotFound();

            return View(customer);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,TelephoneNumber,ContactPersonName,ContactPersonEmailAddress,VATNumber")] Customer customer)
        {
            if (id != customer.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            return View(customer);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null) return NotFound();

            var customer = await _service.GetCustomerByIdAsync(id);

            if (customer == null) return NotFound();

            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteCustomerAsync(id);

            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
