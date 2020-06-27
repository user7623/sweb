using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoMarkt.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AutoMarkt.Controllers
{
    public class VehiclesEmployeeController : Controller
    {
        private readonly AutoMarktContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment he;
        private readonly IWebHostEnvironment hostEnvironment;

        public VehiclesEmployeeController(AutoMarktContext context, IWebHostEnvironment e, IWebHostEnvironment hostEnvironment)
        {
            he = e;
            this.hostEnvironment = hostEnvironment;
            _context = context;

        }

        [HttpPost]
        public async Task<IActionResult> showPicture(string Make, long chassisNumber, IFormFile pic)
        {
            ViewData["fname"] = Make;
            if (pic != null)
            {
                var filename = Path.Combine(he.WebRootPath + "/images/", chassisNumber + Path.GetFileName(pic.FileName));
                pic.CopyTo(new FileStream(filename, FileMode.Create));
                ViewData["filelocation"] = "/" + Path.GetFileName(pic.FileName);
            }
            //napravi kopija od izbraniot student
            //var selected = await _context.Student.Where(s => s.FirstName.Equals(firstName) && s.LastName.Equals(lastName)).FirstOrDefaultAsync();
            var selected = await _context.Vehicle.FirstOrDefaultAsync(s => s.Make.Equals(Make) && s.ChassisNumber.Equals(chassisNumber));
            selected.pic = "/images/" + chassisNumber + Path.GetFileName(pic.FileName);

            //vnesi go vo databaza
            //_context.Add(selected);
            _context.Update(selected);
            await _context.SaveChangesAsync();
            var pom = from p in _context.Vehicle
                      select p;
            pom = pom.Where(p => p.ChassisNumber == selected.ChassisNumber);//sekoe vozilo ima unikaten broj na sasija
            //dodadi vo showPictureview elementi za modelot
            return View();
        }

        public async Task<IActionResult> addPicture(string? id)
        {
            
            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            return View(vehicle);
        }
        // GET: VehiclesEmployee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vehicle.ToListAsync());
        }

        // GET: VehiclesEmployee/Details/5
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

        // GET: VehiclesEmployee/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Make,Colour,cc,Price,EnginePower,Weight,Fuel,ChassisNumber,Description,pic,EmployeeId,SaleDate,BuyerFullname,buyerAddres,BuyerPhone")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: VehiclesEmployee/Edit/5
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

        // GET: VehiclesEmployee/Delete/5
        public async Task<IActionResult> Delete(string id)
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

        // POST: VehiclesEmployee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(string id)
        {
            return _context.Vehicle.Any(e => e.Id == id);
        }
    }
}
