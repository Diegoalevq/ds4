using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_1
{
    public partial class Form1 : Form
    {
        private CalculadoraDistancias calculadora;
        public Form1()
        {
            InitializeComponent();
            calculadora = new CalculadoraDistancias();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = Convert.ToDouble(textVelocidad.Text);
                double tiempo = Convert.ToDouble(textTiempo.Text);
                double distancia = calculadora.CalcularDistancia(velocidad, tiempo);
                textDistancia.Text = $"{distancia:F2} unidades";
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para la velocidad y el tiempo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                textVelocidad.Text = string.Empty;
                textTiempo.Text = string.Empty;
                textDistancia.Text = string.Empty;

            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        
    }
}
