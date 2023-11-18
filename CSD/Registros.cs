using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COSASE.CSD
{
    public class Registros
    {
        public int id_registro {  get; set; }
        public Productos productos { get; set; }
        public Usuario usuario { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}