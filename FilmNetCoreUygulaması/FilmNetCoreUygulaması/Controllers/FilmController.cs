using FilmNetCoreUygulaması.Data;
using FilmNetCoreUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmNetCoreUygulaması.Controllers
{
    public class FilmController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FilmController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Films.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Film film)
        {
            _db.Add(film);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var yenile = _db.Films.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Film film)
        {
            _db.Update(film);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var del = _db.Films.Find(id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")] //uygulamadaki ismi 
        public IActionResult Sil(int id)
        {
            var del = _db.Films.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
