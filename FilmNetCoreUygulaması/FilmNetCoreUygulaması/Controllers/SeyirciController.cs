using FilmNetCoreUygulaması.Data;
using FilmNetCoreUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmNetCoreUygulaması.Controllers
{
    public class SeyirciController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SeyirciController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Seyircis.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Seyirci film)
        {
            _db.Add(film);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var yenile = _db.Seyircis.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Seyirci film)
        {
            _db.Update(film);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var del = _db.Seyircis.Find(id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")] //uygulamadaki ismi 
        public IActionResult Sil(int id)
        {
            var del = _db.Seyircis.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
