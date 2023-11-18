using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COSASE.CSD
{
    public class Productos
    {
        public int idProducto { get; set; }
        public string codigo { get; set;}
        public string nombre_producto {  get; set; }
        public string categoria { get; set;}
        public Usuario nombre_usuario{ get; set;}
        public Usuario id_usuario { get; set;}
        public Registros fecha_regitro { get; set;}

    }
}