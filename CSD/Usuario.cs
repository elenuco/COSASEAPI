using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COSASE.CSD
{
    public class Usuario
    {
        public string id_usuario {  get; set; }
        public string nombre_usuario { get; set;}
        public string id_TipoUsuario {  get; set; }
        public string tipoUsuario { get; set;}
        public string id_cliente { get; set; }
        public string nombre_cuenta { get; set; }
        public string nit { get; set; }
    }
}