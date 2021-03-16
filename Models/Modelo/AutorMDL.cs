using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda.Models.Modelo
{
    public class AutorMDL
    {
        private int id;
        private String nombre;

        public AutorMDL(int id, String nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public AutorMDL(String nombre)
        {
            Nombre = nombre;
        }
        public AutorMDL()
        {

        }
        ~AutorMDL()
        {

        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}