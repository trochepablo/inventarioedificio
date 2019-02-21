using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventarioEdificio.Models
{
    public class GenericClass<T> : Audit
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}