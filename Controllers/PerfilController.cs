using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoTienda.Models;
using ProyectoTienda.Models.Modelo;
namespace ProyectoTienda.Controllers
{
    public class PerfilController : Controller
    {
        
        private int usuarioId;
        public PerfilController()
        {

        }
        // GET: Perfil
        [HttpPost]
        public ActionResult Index(int id)
        {
            ClienteMDL cliente = null;
            usuarioId = id;
            try
            {
                using (proyectoEntities1 db = new proyectoEntities1()) {
                    cliente = (from c in db.cliente
                               where c.usuario.id == id
                               select new ClienteMDL()
                               {
                                   Id = c.id,
                                   Nombre = c.nombre,
                                   Documento = c.documento,
                                   MontoDinero = (double)c.monto_dinero,
                                   FechaNacimiento = c.fecha_nacimiento

                               }).First();
                    
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return Perfil(cliente);
        }

        [HttpPost]
        public ActionResult Perfil(ClienteMDL cliente)
        {
            ViewBag.Cliente = cliente;
            return RedirectToAction("Perfil", "Perfil", new { });
        }
    }
}