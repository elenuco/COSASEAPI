using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using COSASE.CSD;
using Newtonsoft.Json;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using System.Text;

namespace COSASE.CSU
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected async void BtnIngresar_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://exactrack.cosase.com/controller/login.controller.php?login";
            string username = tbUsuario.Text;
            string password = tbPassword.Text;

            // Crear el objeto que se enviará como JSON
            var credentials = new
            {
                user = "jorantes",
                pass = "jorantes2022"
            };
            // Convertir las credenciales a formato JSON
            string jsonCredentials = JsonConvert.SerializeObject(credentials);
            // Crear el contenido de la solicitud HTTP
            var content = new StringContent(jsonCredentials, Encoding.UTF8, "application/json");
            using (var httpClient= new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(apiUrl, content);
                    HttpResponseMessage response = httpResponseMessage;
                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        string  responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Inicio de sesion exitoso. Respuesta del servidor"+responseBody, "Exito", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Inicio de sesión fallido. Código de estado: " + response.StatusCode, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la solicitud" + ex.Message, "Error", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
                }
            }
            
        }

        protected void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://exactrack.cosase.com/controller/login.controller.php?login");
            string Respuesta;

            RestRequest request = new RestRequest();

            var Response = client.Get(request);

            Respuesta = Response.Content;

            Usuario ousuario = JsonConvert.DeserializeObject<Usuario>(Respuesta);

            Usuario ousuarios = ousuario.results[0];
            tbIdUsuario.Text= ousuarios.id_TipoUsuario.ToString();
            nombre_usuario.Text=ousuarios.nombre_usuario.ToString();
            id_TipoUsuario.Text = ousuarios.id_TipoUsuario.ToString();
            id_cliente.Text=ousuarios.id_cliente.ToString();
            nombre_cuenta.Text=ousuarios.nombre_cuenta.ToString();
        }
    }
}