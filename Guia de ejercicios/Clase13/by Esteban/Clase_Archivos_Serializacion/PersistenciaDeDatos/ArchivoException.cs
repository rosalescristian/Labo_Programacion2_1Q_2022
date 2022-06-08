﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ArchivoException : Exception
    {
        public ArchivoException(string mensaje)
           : this(mensaje, null)
        {

        }
        public ArchivoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }
    }
}
