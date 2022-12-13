using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialWeb.Models;

namespace SocialWeb.Controllers
{
    public class ContectDataModelsController : Controller
    {
        private readonly SocialDBContext _context;

        public ContectDataModelsController(SocialDBContext context)
        {
            _context = context;
        }

        
        // GET: ContectDataModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContectDataModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,Email,Phnone")] ContectDataModel contectDataModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contectDataModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contectDataModel);
        }
    }
}
