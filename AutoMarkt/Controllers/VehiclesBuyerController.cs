﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoMarkt.Models;

namespace AutoMarkt.Controllers
{
    public class VehiclesBuyerController : Controller
    {
        private readonly AutoMarktContext _context;

        public VehiclesBuyerController(AutoMarktContext context)
        {
            _context = context;
        }

        // GET: VehiclesBuyer
        public async Task<IActionResult> Index(string Make, int EnginePower, int Price)
        {
            //filtriraj prvo odobreni
            var vehicle = from c in _context.Vehicle
                          select c;
            vehicle = vehicle.Where(d => d.Approved == true);
            //filtriraj po specificni baranja
            if (!String.IsNullOrEmpty(Make))
            {
                vehicle = vehicle.Where(d => d.Make.Contains(Make));
            }
            if(EnginePower != 0)
            {
                vehicle = vehicle.Where(d => d.EnginePower == EnginePower);
            }
            if (Price != 0)
            {
                vehicle = vehicle.Where(d => d.Price == Price);
            }

            return View(await vehicle.ToListAsync());
        }

        // GET: VehiclesBuyer/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: VehiclesBuyer/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Make,Colour,cc,Price,EnginePower,Weight,Fuel,ChassisNumber,Description,pic,EmployeeId,SaleDate,BuyerFullname,buyerAddres,BuyerPhone")] Vehicle vehicle)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(vehicle);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(vehicle);
        //}

        // GET: VehiclesBuyer/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Make,Colour,cc,Price,EnginePower,Weight,Fuel,ChassisNumber,Description,pic,EmployeeId,SaleDate,BuyerFullname,buyerAddres,BuyerPhone")] Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.Id))
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
            return View(vehicle);
        }

        // GET: VehiclesBuyer/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var vehicle = await _context.Vehicle
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (vehicle == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(vehicle);
        //}

        //// POST: VehiclesBuyer/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var vehicle = await _context.Vehicle.FindAsync(id);
        //    _context.Vehicle.Remove(vehicle);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool VehicleExists(string id)
        {
            return _context.Vehicle.Any(e => e.Id == id);
        }
    }
}
