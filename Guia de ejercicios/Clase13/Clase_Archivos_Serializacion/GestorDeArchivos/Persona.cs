using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GestorDeArchivos
{
    //ESTOS DECORADORES VAN EN LA CLASE BASE//
    [XmlInclude(typeof(Alumno))]    // Se agrega un decorador por cada clase derivada que tengamos
    [XmlInclude(typeof(Profesor))]  // Se agrega un decorador por cada clase derivada que tengamos
    public  class Persona
    {

    }
}
