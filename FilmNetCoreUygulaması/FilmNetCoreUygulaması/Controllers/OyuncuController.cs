using FilmNetCoreUygulaması.Data;
using FilmNetCoreUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmNetCoreUygulaması.Controllers
{
    public class OyuncuController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OyuncuController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Oyuncus.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Oyuncu film)
        {
            _db.Add(film);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var yenile = _db.Oyuncus.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Oyuncu film)
        {
            _db.Update(film);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var del = _db.Oyuncus.Find(id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")] //uygulamadaki ismi 
        public IActionResult Sil(int id)
        {
            var del = _db.Oyuncus.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
