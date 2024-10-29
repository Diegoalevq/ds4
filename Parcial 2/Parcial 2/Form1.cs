using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        private Conversiones convertir;
        private List<string> historialConversiones = new List<string>();
        public Form1()
        {
            InitializeComponent();
            convertir = new Conversiones();
        }
        private void ActualizarHistorial(string conversion)
        {
            historialConversiones.Add(conversion);
            listBoxHistorial.Items.Add(conversion);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBiDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                string PasvBinario = textPasvBinario.Text;
                int BiDecimal = convertir.BinarioADecimal(PasvBinario);
                textBiDecimal.Text = BiDecimal.ToString();

                ActualizarHistorial($"Binario a Decimal: {PasvBinario} -> {BiDecimal}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese únicamente valores de tipo numéricos.", "Error de Formato.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecimalBi_Click(object sender, EventArgs e)
        {
            try
            {
                int PasvDecimalBi = Convert.ToInt32(textPasvDecimalBi.Text);
                string Binario = convertir.DecimalABinario(PasvDecimalBi);
                textBinario.Text = Binario;

                ActualizarHistorial($"Decimal a Binario: {PasvDecimalBi} -> {Binario}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese únicamente valores de tipo numéricos.", "Error de Formato.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOctDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                string PasvOctal = textOctal.Text;
                int OctDecimal = convertir.OctalADecimal(PasvOctal);
                textOctDecimal.Text = OctDecimal.ToString();

                ActualizarHistorial($"Octal a Decimal: {PasvOctal} -> {OctDecimal}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese únicamente valores de tipo numéricos.", "Error de Formato.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecimalOct_Click(object sender, EventArgs e)
        {
            try
            {
                int PasvDecimalOct = Convert.ToInt32(textPasvDecimalOct.Text);
                string Octal = convertir.DecimalAOctal(PasvDecimalOct);
                textOctal.Text = Octal;

                ActualizarHistorial($"Decimal a Octal: {PasvDecimalOct} -> {Octal}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese únicamente valores de tipo numéricos.", "Error de Formato.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}