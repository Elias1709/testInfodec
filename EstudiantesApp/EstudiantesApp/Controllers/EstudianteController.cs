using EstudiantesApp.Datos;
using EstudiantesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EstudiantesApp.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EstudianteController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable <Estudiante> lista = _db.Estudiante;

            return View(lista);
        }

        public IActionResult Mostrar(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Estudiante.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Crear()
        {          

            return View();
        }

        [HttpPost]
        public IActionResult Crear (Estudiante estudiante)
        {
            if(ModelState.IsValid)
            {
                float promedio = (estudiante.Parcial1+estudiante.Parcial2+estudiante.Parcial3) / 3;
                estudiante.Final = promedio;
                _db.Estudiante.Add(estudiante);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);      
                        
        }

        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Estudiante.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]        
        public IActionResult Editar(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                float promedio = (estudiante.Parcial1 + estudiante.Parcial2 + estudiante.Parcial3) / 3;
                estudiante.Final = promedio;
                _db.Estudiante.Update(estudiante);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);

        }

        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Estudiante.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Eliminar(Estudiante estudiante)
        {
            if (estudiante == null)
            {
                return NotFound();

            }
            _db.Estudiante.Remove(estudiante);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }




    }
}
