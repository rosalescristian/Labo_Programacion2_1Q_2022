using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private Cantina singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.Botellas;
            }
        }

        private Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
            this.botellas = new List<Botella>();
        }

        public Cantina GetCantina(int espacios)
        {
            if(singleton is null)
            {
                return singleton = new Cantina(espacios);
            }
            this.espaciosTotales += espacios;
            return this.singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if (c is not null && b is not null && c.espaciosTotales > c.Botellas.Count)
            {
                c.botellas.Add(b);
                return true;
            }
            return false;
        }
    }
}
