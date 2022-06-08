﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Cliente))]
    public class Persona
    {
        private string nombre;
        private string apellido;
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string NombreCompleto
        {
            get
            {
                return $"{nombre} {apellido}";
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
