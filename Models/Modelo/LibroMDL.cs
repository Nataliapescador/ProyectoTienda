using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using ProyectoTienda.Models;
namespace ProyectoTienda.Models.Modelo
{
    public class LibroMDL
    {
        #region Atributos
            private int id;
            private String codigo;
            private String nombre;
            private String descripcion;
            private int paginas;
            private double precioSugerido;
            private DateTime fechaCreacion;
            private GeneroMDL genero;
            private AutorMDL autor;
        #endregion FinAtributos

        #region Constructores
            public LibroMDL(int id, String codigo, String nombre, String descripcion,GeneroMDL genero,AutorMDL autor,int paginas, double precioSugerido, DateTime fechaCreacion)
            {
                Id = id;
                Codigo = codigo;
                Genero = genero;
                Nombre = nombre;
                Autor = autor;
                Paginas = paginas;
                Descripcion = descripcion;
                PrecioSugerido = precioSugerido;
                FechaCreacion = fechaCreacion;
            }
            public LibroMDL(String codigo, String nombre, String descripcion, int paginas, double precioSugerido, DateTime fechaCreacion)
            {
                Codigo = codigo;
                Nombre = nombre;
                Paginas = paginas;
                Descripcion = descripcion;
                PrecioSugerido = precioSugerido;
                FechaCreacion = fechaCreacion;
            }
            public LibroMDL()
            {

            }
            public LibroMDL(int id, String codigo, String nombre, int paginas, double precioSugerido, DateTime fechaCreacion)
            {
                Id = id;
                Codigo = codigo;
                Nombre = nombre;
                Paginas = paginas;
                PrecioSugerido = precioSugerido;
                FechaCreacion = fechaCreacion;
            }
        #endregion FinConstructores

        #region Destructor
        ~LibroMDL()
        {

        }
        #endregion FinDestructor

        #region Propiedades
            public int Id
            {
                get => id;
                set => id = value;
            }
            public string Codigo { get => codigo; private set => codigo = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int Paginas { get => paginas; set => paginas = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public double PrecioSugerido { get => precioSugerido; set => precioSugerido = value; }
            public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public GeneroMDL Genero { get => genero; set => genero = value; }
        public AutorMDL Autor { get => autor; set => autor = value; }
        #endregion FinPropiedades
    }
}