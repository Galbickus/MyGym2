using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGym2.entidades
{
    internal class Visitante : Persona
    {
        public int IdNoSocio { get; }
        public bool AptoFisico { get; set; }
        //La version no admite programacion funcional
        public List<Actividad> listaActividades { get; set; }

        public Visitante(int idNoSocio, bool aptoFisico, string nombre, string apellido, string dni,
            string email, string telefono)
            : base(nombre, apellido, dni, email, telefono)
        {
            this.IdNoSocio = idNoSocio;
            this.AptoFisico = aptoFisico;
        }

        public Visitante(bool aptoFisico, string nombre, string apellido, string dni,
            string email, string telefono)
            : base(nombre, apellido, dni, email, telefono)
        {
            this.AptoFisico = aptoFisico;
        }

    }
}
