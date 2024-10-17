namespace Laboratorio_12_3
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
            this.btnSemiper = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSemiper = new System.Windows.Forms.TextBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.textLadoC = new System.Windows.Forms.TextBox();
            this.textLadoB = new System.Windows.Forms.TextBox();
            this.textLadoA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la longitud del lado A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa la longitud del lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa la longitud del lado C";
            // 
            // btnSemiper
            // 
            this.btnSemiper.Location = new System.Drawing.Point(25, 194);
            this.btnSemiper.Name = "btnSemiper";
            this.btnSemiper.Size = new System.Drawing.Size(123, 46);
            this.btnSemiper.TabIndex = 3;
            this.btnSemiper.Text = "Semiperimetro";
            this.btnSemiper.UseVisualStyleBackColor = true;
            this.btnSemiper.Click += new System.EventHandler(this.btnSemiper_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(154, 194);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(123, 46);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 46);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(412, 194);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(123, 46);
            this.btnSalida.TabIndex = 6;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calcular Semiperimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area del  Triangulo";
            // 
            // textSemiper
            // 
            this.textSemiper.Location = new System.Drawing.Point(280, 306);
            this.textSemiper.Name = "textSemiper";
            this.textSemiper.Size = new System.Drawing.Size(100, 26);
            this.textSemiper.TabIndex = 9;
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(280, 364);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(100, 26);
            this.textArea.TabIndex = 10;
            // 
            // textLadoC
            // 
            this.textLadoC.Location = new System.Drawing.Point(280, 115);
            this.textLadoC.Name = "textLadoC";
            this.textLadoC.Size = new System.Drawing.Size(100, 26);
            this.textLadoC.TabIndex = 11;
            // 
            // textLadoB
            // 
            this.textLadoB.Location = new System.Drawing.Point(280, 69);
            this.textLadoB.Name = "textLadoB";
            this.textLadoB.Size = new System.Drawing.Size(100, 26);
            this.textLadoB.TabIndex = 12;
            // 
            // textLadoA
            // 
            this.textLadoA.Location = new System.Drawing.Point(280, 30);
            this.textLadoA.Name = "textLadoA";
            this.textLadoA.Size = new System.Drawing.Size(100, 26);
            this.textLadoA.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textLadoA);
            this.Controls.Add(this.textLadoB);
            this.Controls.Add(this.textLadoC);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.textSemiper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSemiper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSemiper;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSemiper;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.TextBox textLadoC;
        private System.Windows.Forms.TextBox textLadoB;
        private System.Windows.Forms.TextBox textLadoA;
    }
}

