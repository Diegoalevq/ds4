using System;

namespace Parcial_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPasvBinario = new System.Windows.Forms.TextBox();
            this.textPasvDecimalBi = new System.Windows.Forms.TextBox();
            this.btnBiDecimal = new System.Windows.Forms.Button();
            this.btnDecimalBi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOctDecimal = new System.Windows.Forms.Button();
            this.btnDecimalOct = new System.Windows.Forms.Button();
            this.textPasvOctal = new System.Windows.Forms.TextBox();
            this.textPasvDecimalOct = new System.Windows.Forms.TextBox();
            this.textBiDecimal = new System.Windows.Forms.TextBox();
            this.textBinario = new System.Windows.Forms.TextBox();
            this.textOctDecimal = new System.Windows.Forms.TextBox();
            this.textOctal = new System.Windows.Forms.TextBox();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor Númerico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Binario a Decimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decimal a Binario";
            // 
            // textPasvBinario
            // 
            this.textPasvBinario.Location = new System.Drawing.Point(209, 86);
            this.textPasvBinario.Name = "textPasvBinario";
            this.textPasvBinario.Size = new System.Drawing.Size(100, 26);
            this.textPasvBinario.TabIndex = 3;
            // 
            // textPasvDecimalBi
            // 
            this.textPasvDecimalBi.Location = new System.Drawing.Point(209, 159);
            this.textPasvDecimalBi.Name = "textPasvDecimalBi";
            this.textPasvDecimalBi.Size = new System.Drawing.Size(100, 26);
            this.textPasvDecimalBi.TabIndex = 4;
            // 
            // btnBiDecimal
            // 
            this.btnBiDecimal.Location = new System.Drawing.Point(363, 83);
            this.btnBiDecimal.Name = "btnBiDecimal";
            this.btnBiDecimal.Size = new System.Drawing.Size(75, 29);
            this.btnBiDecimal.TabIndex = 5;
            this.btnBiDecimal.Text = "->";
            this.btnBiDecimal.UseVisualStyleBackColor = true;
            this.btnBiDecimal.Click += new System.EventHandler(this.btnBiDecimal_Click);
            // 
            // btnDecimalBi
            // 
            this.btnDecimalBi.Location = new System.Drawing.Point(363, 159);
            this.btnDecimalBi.Name = "btnDecimalBi";
            this.btnDecimalBi.Size = new System.Drawing.Size(75, 29);
            this.btnDecimalBi.TabIndex = 6;
            this.btnDecimalBi.Text = "->";
            this.btnDecimalBi.UseVisualStyleBackColor = true;
            this.btnDecimalBi.Click += new System.EventHandler(this.btnDecimalBi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Octal a Decimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Decimal a Octal";
            // 
            // btnOctDecimal
            // 
            this.btnOctDecimal.Location = new System.Drawing.Point(363, 230);
            this.btnOctDecimal.Name = "btnOctDecimal";
            this.btnOctDecimal.Size = new System.Drawing.Size(75, 29);
            this.btnOctDecimal.TabIndex = 9;
            this.btnOctDecimal.Text = "->";
            this.btnOctDecimal.UseVisualStyleBackColor = true;
            this.btnOctDecimal.Click += new System.EventHandler(this.btnOctDecimal_Click);
            // 
            // btnDecimalOct
            // 
            this.btnDecimalOct.Location = new System.Drawing.Point(363, 291);
            this.btnDecimalOct.Name = "btnDecimalOct";
            this.btnDecimalOct.Size = new System.Drawing.Size(75, 29);
            this.btnDecimalOct.TabIndex = 10;
            this.btnDecimalOct.Text = "->";
            this.btnDecimalOct.UseVisualStyleBackColor = true;
            this.btnDecimalOct.Click += new System.EventHandler(this.btnDecimalOct_Click);
            // 
            // textPasvOctal
            // 
            this.textPasvOctal.Location = new System.Drawing.Point(209, 230);
            this.textPasvOctal.Name = "textPasvOctal";
            this.textPasvOctal.Size = new System.Drawing.Size(100, 26);
            this.textPasvOctal.TabIndex = 11;
            // 
            // textPasvDecimalOct
            // 
            this.textPasvDecimalOct.Location = new System.Drawing.Point(209, 291);
            this.textPasvDecimalOct.Name = "textPasvDecimalOct";
            this.textPasvDecimalOct.Size = new System.Drawing.Size(100, 26);
            this.textPasvDecimalOct.TabIndex = 12;
            // 
            // textBiDecimal
            // 
            this.textBiDecimal.Location = new System.Drawing.Point(498, 86);
            this.textBiDecimal.Name = "textBiDecimal";
            this.textBiDecimal.Size = new System.Drawing.Size(100, 26);
            this.textBiDecimal.TabIndex = 13;
            // 
            // textBinario
            // 
            this.textBinario.Location = new System.Drawing.Point(498, 158);
            this.textBinario.Name = "textBinario";
            this.textBinario.Size = new System.Drawing.Size(100, 26);
            this.textBinario.TabIndex = 14;
           
            // 
            // textOctDecimal
            // 
            this.textOctDecimal.Location = new System.Drawing.Point(498, 233);
            this.textOctDecimal.Name = "textOctDecimal";
            this.textOctDecimal.Size = new System.Drawing.Size(100, 26);
            this.textOctDecimal.TabIndex = 15;
            // 
            // textOctal
            // 
            this.textOctal.Location = new System.Drawing.Point(498, 291);
            this.textOctal.Name = "textOctal";
            this.textOctal.Size = new System.Drawing.Size(100, 26);
            this.textOctal.TabIndex = 16;
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.FormattingEnabled = true;
            this.listBoxHistorial.ItemHeight = 20;
            this.listBoxHistorial.Location = new System.Drawing.Point(51, 337);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(120, 84);
            this.listBoxHistorial.TabIndex = 17;
            this.listBoxHistorial.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxHistorial);
            this.Controls.Add(this.textOctal);
            this.Controls.Add(this.textOctDecimal);
            this.Controls.Add(this.textBinario);
            this.Controls.Add(this.textBiDecimal);
            this.Controls.Add(this.textPasvDecimalOct);
            this.Controls.Add(this.textPasvOctal);
            this.Controls.Add(this.btnDecimalOct);
            this.Controls.Add(this.btnOctDecimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDecimalBi);
            this.Controls.Add(this.btnBiDecimal);
            this.Controls.Add(this.textPasvDecimalBi);
            this.Controls.Add(this.textPasvBinario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPasvBinario;
        private System.Windows.Forms.TextBox textPasvDecimalBi;
        private System.Windows.Forms.Button btnBiDecimal;
        private System.Windows.Forms.Button btnDecimalBi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOctDecimal;
        private System.Windows.Forms.Button btnDecimalOct;
        private System.Windows.Forms.TextBox textPasvOctal;
        private System.Windows.Forms.TextBox textPasvDecimalOct;
        private System.Windows.Forms.TextBox textBiDecimal;
        private System.Windows.Forms.TextBox textBinario;
        private System.Windows.Forms.TextBox textOctDecimal;
        private System.Windows.Forms.TextBox textOctal;
        private System.Windows.Forms.ListBox listBoxHistorial;
    }
}

