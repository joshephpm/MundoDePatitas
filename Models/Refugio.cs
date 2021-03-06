using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace Patitas.Models
{
    public partial class Refugio
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaDeCreacion { get; set; }

        public string Logo { get; set; }

        public List<Mascota> Mascotas { get; set; }




    }
}