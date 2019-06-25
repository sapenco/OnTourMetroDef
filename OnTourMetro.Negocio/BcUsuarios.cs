using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTourMetro.Datos;
using OnTourMetro.Modelo;

namespace OnTourMetro.Negocio
{
    public class BcUsuarios
    {
        public List<Usuarios> ReadAll()
        {
            return new DcUsuarios().ReadAll();
        }

        public bool Create(Usuarios usr)
        {
            return new DcUsuarios().Create(usr);
        }

        public Usuarios ReadByColegio(string colegio)
        {
            return new DcUsuarios().ReadByColegio(colegio);
        }

        public Usuarios ReadByCurso(string curso)
        {
            return new DcUsuarios().ReadByCurso(curso);
        }
    }
}
