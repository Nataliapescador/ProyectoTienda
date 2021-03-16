using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using ProyectoTienda.Models;
using ProyectoTienda.Models.Modelo;
namespace ProyectoTienda.Controllers
{
    public class LibrosController : Controller
    {
        // GET: Libros
        public ActionResult Index()
        {
            List<LibroMDL> listaLibros = null;
            try
            {
                using (proyectoEntities1 tienda = new proyectoEntities1())
                {
                    listaLibros = (from t in tienda.libro
                                   select new LibroMDL()
                                   {
                                       Id = t.id,
                                       Nombre = t.nombre,
                                       Descripcion = t.descripcion,
                                       FechaCreacion = t.fecha_creacion,
                                       Genero = new GeneroMDL()
                                       {
                                           Nombre = t.genero.nombre,
                                           Id =  t.genero.id
                                       },
                                       Autor = new AutorMDL()
                                       {
                                           Id = t.autor.id,
                                           Nombre = t.autor.nombre
                                       }

                                   }
                                   ).ToList();
                }
            }
            catch (SqlException)
            {

            }
            catch (Exception)
            {

            }
            return View(listaLibros);
        }
    }
}