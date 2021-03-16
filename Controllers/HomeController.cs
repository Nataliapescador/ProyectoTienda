using ProyectoTienda.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProyectoTienda.Models.Modelo;
using System.Web.Mvc;

namespace ProyectoTienda.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String usuario, String contrasenia)
        {
            try
            {
                using (proyectoEntities1 db = new proyectoEntities1())
                {
                    UsuarioMDL cliente = (
                            from us in db.usuario
                            where us.usuario1 == usuario && us.contrasenia == contrasenia
                            select new UsuarioMDL()
                            {
                                Id = us.id
                                
                            }
                            ).First();
                    if(cliente != null)
                    {
                        PerfilController p = new PerfilController();
                        return p.Index(cliente.Id);
                    }
                    
                }
                
            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
            catch (Exception)
            {
                Console.WriteLine("No se encontro el usuario");
            }
            return View("Registro");
        }

        [HttpPost]
        public ActionResult Registro(String nombre, String documento, DateTime fechaNacimiento,String usuario,String contrasenia)
        {
            ViewBag.Mensaje = null;
            try
            {
                usuario us = null;
                using (proyectoEntities1 c = new proyectoEntities1())
                {
                    us = new usuario()
                    {
                        usuario1 = usuario,
                        contrasenia = contrasenia
                    };
                    c.usuario.Add(us);
                    c.SaveChanges();
                    int id = us.id;
                    c.cliente.Add(new cliente()
                    {
                        nombre = nombre,
                        documento = documento,
                        fecha_nacimiento = fechaNacimiento,
                        usuario_id= id
                    });
                    c.SaveChanges();
                    RedirectToAction("Index");
                }
                  
            }
            catch (SqlException)
            {
                ViewBag.Mensaje = "No fue posible registrar el usuario";
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           return View();
        }

        public ActionResult Registro()
        {
            ViewBag.Mensaje = null;
            return View();
        }
    }
}