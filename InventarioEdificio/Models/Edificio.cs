using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventarioEdificio.Models
{
    public class Edificio : GenericClass<int>
    {
        public DateTime Date { get; set; }
        public string Adress { get; set; }
        public string Technical { get; set; }
    }
}