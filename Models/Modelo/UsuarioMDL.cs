using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda.Models.Modelo
{
    public class UsuarioMDL
    {
        private int id;
        private string usuario;
        private string contrasenia;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }


        public UsuarioMDL()
        {
           
        }


        public UsuarioMDL(int id, String usuario, String contraseña)
        {
            Id = id;
            Usuario = usuario;
            Contrasenia = contraseña;
        }


        public UsuarioMDL( String usuario, String contraseña )
        {
            Usuario = usuario;
            Contrasenia = contraseña;
        }
    }
}