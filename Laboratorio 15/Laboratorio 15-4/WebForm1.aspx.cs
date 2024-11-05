using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private object resultado;

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);
                int resultado = num1 + num2;

                lblResultado.Text = resultado.ToString();

            }catch (FormatException)
            {
                lblResultado.Text = "Por favor ingresa números válidos.";
            }
        }

        protected void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}