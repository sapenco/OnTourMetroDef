using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnTourMetro.Datos
{
    public class OntourEDM
    {
        private static ING_SoftwareEntities _instancia = null;
        private static readonly object bloqueo = new object();

        private OntourEDM() { }

        public static ING_SoftwareEntities Entidades
        {
            get
            {
                lock (bloqueo)
                {
                    if (_instancia == null)
                    {
                        _instancia = new ING_SoftwareEntities();
                    }
                }
                return _instancia;
            }
        }
    }
}
