using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGym2.entidades
{
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }

        //la version 7.3 no admite programacion funcional no sacar ?
        public string Email { get; set; }
        public string Telefono { get; set; }

        protected Persona(string nombre, string apellido, string dni, string email, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = email;
            Telefono = telefono;
        }

        protected Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
    }
}
