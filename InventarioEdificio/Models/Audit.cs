using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventarioEdificio.Models
{
    public class Audit
    {
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Usuario { get; set; }
    }
}