using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocuGuard.Controllers
{
    public class Home_Usuario : Controller
    {
        // GET: Home_Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home_Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home_Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home_Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home_Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home_Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home_Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home_Usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
