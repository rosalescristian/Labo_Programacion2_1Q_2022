using System;

namespace Biblioteca
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string direccion;

        public Cliente()
        {

        }

        public Cliente(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public Cliente(int id, string nombre, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} - Domicilio: {Direccion}";
        }


    }
}
