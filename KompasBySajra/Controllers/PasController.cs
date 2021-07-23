using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KompasBySajra.Data;
using KompasBySajra.Models;

namespace KompasBySajra.Controllers
{
    public class PasController : Controller
    {
        // private readonly DataContext _context;

        static List<Pas> psi = new List<Pas>()
        {
            new Pas(1, "Bagi", 5, "buldog", 45, true),
            new Pas(2, "Luli", 23, "snaucer", 34, false),
            new Pas(3, "Lesi", 4, "pufnica", 23, true),
        };

        public PasController(DataContext context)
        {
            
        }

        // GET: Pas
        public IActionResult Index()
        {
            return View(psi);
        }

        // GET: Pas/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pas =  psi.Find(m => m.ID == id);
            if (pas == null)
            {
                return NotFound();
            }

            return View(pas);
        }

        // GET: Pas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("ID,ime,starosnaDob,rasa,tezina,zdravstveniProblemi,kastriranSterilisan,slika")] Pas pas)
        {
            if (ModelState.IsValid)
            {
                psi.Add(pas);
                return RedirectToAction(nameof(Index));
            }
            return View(pas);
        }

        // GET: Pas/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pas = psi.Find(p => p.ID == id);
            if (pas == null)
            {
                return NotFound();
            }
            return View(pas);
        }

        // POST: Pas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ID,ime,starosnaDob,rasa,tezina,kastriranSterilisan")] Pas pas)
        {
            if (id != pas.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Pas p = psi.Find(pr => pr.ID == pas.ID);
                    psi.Remove(p);
                    psi.Add(pas);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasExists(pas.ID))
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
            return View(pas);
        }

        // GET: Pas/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pas = psi.Find(m => m.ID == id);
            if (pas == null)
            {
                return NotFound();
            }

            return View(pas);
        }

        // POST: Pas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var pas = psi.Find( p => p.ID == id);
            psi.Remove(pas);
            return RedirectToAction(nameof(Index));
        }

        private bool PasExists(int id)
        {
            return psi.Any(e => e.ID == id);
        }
    }
}
