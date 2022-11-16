using Microsoft.AspNetCore.Mvc;

namespace MvcTutorial.Controllers
{
    public class UsuariosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaUsuarios()
        {

            List<string> listaUsuarios=new List<string>();
            listaUsuarios.Add("javi");
            listaUsuarios.Add("gómez");
            listaUsuarios.Add("cano");
            listaUsuarios.Add("ramirez");

            //ViewBag.ListaUsuarios = listaUsuarios;  CONTROLADOR-VISTA
            // TempData["ListaUsuarios"] = listaUsuarios; //CONTROLADOR-CONTROLADOR
            //Session["ListaUsuarios"] = listaUsuarios;//CONTROLADOR-CONTROLADOR
            ViewData["ListaUsuarios"] = listaUsuarios;
            return View(listaUsuarios); //CONTROLADOR - VISTA
        }
        [HttpPost]
        public IActionResult ListaUsuarios(string lista)
        {

            ViewBag.Nombre = lista;
            //List<string> listausuarios = ViewBag.ListaUsuarios;
            //List<string> listausuarios =((List<string>)TempData["ListaUsuarios"]);
            //List<string> listausuarios =((List<string>)Session["ListaUsuarios"]);
            List<string> listausuarios =((List<string>)ViewData["ListaUsuarios"]);

            return View(listausuarios);
        }
    }
}
