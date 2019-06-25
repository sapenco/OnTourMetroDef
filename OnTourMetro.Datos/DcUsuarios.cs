using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTourMetro.Modelo;

namespace OnTourMetro.Datos
{
    public class DcUsuarios
    {
        public List<Usuarios> ReadAll()
        {
            using (ING_SoftwareEntities context = new ING_SoftwareEntities())
            {
                return context.Usuarios.ToList();
            }
        }

        public bool Create(Usuarios usr)
        {
            OntourEDM.Entidades.Usuarios.Add(usr);
            OntourEDM.Entidades.SaveChanges();
            return true;
        }

        public Usuarios ReadByColegio(string colegio)
        {
          return OntourEDM.Entidades.Usuarios.FirstOrDefault(r => r.Colegio == colegio);
        }

        public Usuarios ReadByCurso(string curso)
        {
            return OntourEDM.Entidades.Usuarios.FirstOrDefault(r => r.Curso == curso);
        }
    }
}
