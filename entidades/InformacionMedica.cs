using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGym2.entidades
{
    internal class InformacionMedica
    {
        public int IdSocio { get; set; }
        public string CoberturaMedica { get; set; }
        public string ContactoEmergencia { get; set; }
        public DateTime VencimientoApto { get; set; }

        public InformacionMedica(int idSocio, string cobertura, string contacto, DateTime vencimiento)
        {
            IdSocio = idSocio;
            CoberturaMedica = cobertura;
            ContactoEmergencia = contacto;
            VencimientoApto = vencimiento;
        }

    }
}
