using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using RestSharp;
using COSASE.CSD;

namespace COSASE.CSU
{
    public partial class LogIn : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnIngresar_Click (object sender, EventArgs e){
            
            //Conexion a la API
            RestClient client = new RestClient("https://exactrack.cosase.com/controller/login.controller.php?login");
            string username = tbUser.Text;
            string password = tbPassword.Text;
            string Respuesta;
            var credentials = new
            {
                user = username,
                pass = password
            };
            // Convertir las credenciales a formato JSON
            string jsonCredentials = JsonConvert.SerializeObject(credentials);
            RestRequest request = new RestRequest();
            var Response =client.Get(request);
            Respuesta=Response.Content;
            Resultados oresultado=JsonConvert.DeserializeObject<Resultados>(Respuesta);
            Usuario ousuario = oresultado.results[0];
            txtIdUsuario.Text = ousuario.id_usuario;
            txtIdTipoUsuario.Text = ousuario.id_TipoUsuario;
            txtNombreUsuario.Text = ousuario.nombre_usuario;
            txtTipoUsuario.Text = ousuario.tipoUsuario;
            txtIdCliete.Text = ousuario.id_cliente;
            txtNit.Text = ousuario.nit;
            
        }
    }
}