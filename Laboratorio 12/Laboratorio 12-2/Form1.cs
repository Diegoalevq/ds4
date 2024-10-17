using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        private SacarPromedios calcular;
        public Form1()
        {
            InitializeComponent();
            calcular = new SacarPromedios();
        }

        private void btnProm_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(textNota1.Text);
                double nota2 = Convert.ToDouble(textNota2.Text);
                double nota3 = Convert.ToDouble(textNota3.Text);
                double PromedioTotal = calcular.CalcularPromedios(nota1, nota2, nota3);
                textPromedioTotal.Text = $"{PromedioTotal:F2}";

            }catch (Exception ex)
            {
                MessageBox.Show("Utilice solamente valores númericos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textNota1.Text = string.Empty;
            textNota2.Text = string.Empty;
            textNota3.Text = string.Empty;
            textPromedioTotal.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
