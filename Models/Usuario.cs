using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Models
{
    public class Usuario : Base
    {
        static readonly DateTime defaultFechaNacimiento = DateTime.Today.AddYears(-20);

        public string? Username { get; set; }
        public string? Nombre { get; set; }
        public uint Codigo { get; set; }
        public byte Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; } = defaultFechaNacimiento;
        public string? Password { get; set; }
        public string? Dui { get; set; }
        public string? Nit { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public uint MunicipioId { get; set; } = 1;
        public byte NecesitaPassword { get; set; }
        public byte Bloqueado { get; set; }
    }
}
