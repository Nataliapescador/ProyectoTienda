using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda.Models.Modelo
{
    public class GeneroMDL
    {
        private int id;
        private String nombre;

        public GeneroMDL(int id, String nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public GeneroMDL(String nombre)
        {
            Nombre = nombre;
        }
        public GeneroMDL()
        {

        }
        ~GeneroMDL()
        {

        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}