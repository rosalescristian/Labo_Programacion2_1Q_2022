using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gato : Animal
    {
        string juguetePreferido;
        int id;
        public Gato(string nombre):base(nombre)
        {

        }
        public override string EmitirSonido()//Se usa OVERRIDE para cambiar el metodo de la clase base (Metodo Sobrescrito)
        {
            return "Miau miau";
        }

        public new string Pensar()
        {
            return "Estoy pensando en dominar el mundo...";
        }

        //Estos metodos pueden estar en una clase superior y ser reutilizados en las herencias.
        public static bool operator ==(Gato g1, Gato g2)
        {
            //return g1 is not null && g2 is not null && g1.nombre == g2.nombre;
            return (Animal)g1 == g2 && g1.juguetePreferido == g2.juguetePreferido; // asi reutilizamos el == de la clase Padre
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            Gato gato = obj as Gato; // Si NO uso AS, tengo que poner el "gato is not null"
                                     // en el return
                                     // Si puede convertir obj a Gato lo guarda en la instancia
                                     // si no lo puede convertir guarda NULL
                                     // AS es un operador (leer documentacion)
            return gato is not null && this == gato;
        }

        public override int GetHashCode()
        {
            //return nombre.GetHashCode();   
            //return (nombre,juguetePreferido).GetHashCode();//compara por instancia en el nombre. Puede ser 1 atributo o una Tupla.
            return id; // si tenemos un identificador unico por cada instancia
        }


    }
}
