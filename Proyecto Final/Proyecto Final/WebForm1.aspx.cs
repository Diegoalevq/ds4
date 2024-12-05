using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.Services;
using System.Web.Script.Services;

namespace Proyecto_Final
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string IconosJSON;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Código de inicialización, si es necesario
            }
        }

        public void GuardarPuntaje(string nombre, int tiempo, int movimientos)
        {
            string connString = ConfigurationManager.ConnectionStrings["MemoramaDBContext"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Puntajes (Nombre, Tiempo, Movimientos) VALUES (@Nombre, @Tiempo, @Movimientos)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Usando Add para especificar el tipo de dato
                        cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 100).Value = nombre;
                        cmd.Parameters.Add("@Tiempo", System.Data.SqlDbType.Int).Value = tiempo;
                        cmd.Parameters.Add("@Movimientos", System.Data.SqlDbType.Int).Value = movimientos;

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Es recomendable registrar el error en lugar de solo mostrarlo
                    // Logger.Error(ex.Message);
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void GuardarPuntajeWeb(string nombre, int tiempo, int movimientos)
        {
            WebForm1 webForm = new WebForm1();
            webForm.GuardarPuntaje(nombre, tiempo, movimientos);
        }
    }
}