using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda.Models.Modelo
{
    public class ClienteMDL
    {
        private int id;
        private String nombre;
        private String documento;
        private UsuarioMDL usuario;
        private DateTime fechaNacimiento;
        private double? montoDinero;

        public ClienteMDL(double montoDinero, string nombre, int id, string documento, UsuarioMDL usuario, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Id = id;
            Documento = documento;
            Usuario = usuario;
            FechaNacimiento = fechaNacimiento;
            MontoDinero = montoDinero;
        }

        public ClienteMDL()
        {

        }

        public ClienteMDL(string nombre, string documento, UsuarioMDL usuario, DateTime fechaNacimiento, double? montoDinero)
        {
            Nombre = nombre;
            Documento = documento;
            Usuario = usuario;
            FechaNacimiento = fechaNacimiento;
            MontoDinero = montoDinero;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string Documento { get => documento; set => documento = value; }
        public UsuarioMDL Usuario { get => usuario; set => usuario = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public double? MontoDinero { get => montoDinero; set => montoDinero = value; }
    }
}