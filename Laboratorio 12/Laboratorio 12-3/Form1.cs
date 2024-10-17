using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        private CalcularA_P calcularP;
        private CalcularA_P calcularA;
        public Form1()
        {
            InitializeComponent();
            calcularA = new CalcularA_P();
            calcularP = new CalcularA_P();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSemiper_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = Convert.ToDouble(textLadoA.Text);
                double ladoB = Convert.ToDouble(textLadoB.Text);
                double ladoC = Convert.ToDouble(textLadoC.Text);
                double Semiper = calcularP.CalcularSemiper(ladoA, ladoB, ladoC);
                textSemiper.Text = $"{Semiper:F2} cm";
            } catch (FormatException)
            {
                MessageBox.Show("Ingrese únicamente un valor de tipo númerico.",  "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textLadoA.Text = string.Empty;
            textLadoB.Text = string.Empty;
            textLadoC.Text = string.Empty;
            textSemiper.Text = string.Empty;
            textArea.Text = string.Empty;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = Convert.ToDouble(textLadoA.Text);
                double ladoB = Convert.ToDouble(textLadoB.Text);
                double ladoC = Convert.ToDouble(textLadoC.Text);
                double Area = calcularA.CalcularArea(ladoA, ladoB, ladoC);
                textArea.Text = $"{Area:F2} cm²";
            }catch (FormatException)
            {
                MessageBox.Show("Ingrese únicamente un valor de tipo númerico.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
