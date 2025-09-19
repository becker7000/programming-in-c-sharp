namespace CalculadoraIMC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EstaturaTextBox = new System.Windows.Forms.TextBox();
            this.MasaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.DiagnosticarButton = new System.Windows.Forms.Button();
            this.DiagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de índice de masa corporal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.LimpiarButton);
            this.groupBox2.Controls.Add(this.DiagnosticarButton);
            this.groupBox2.Controls.Add(this.MasaTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EstaturaTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.DiagnosticoTextBox);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(1, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Escribe tu estatura (m):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EstaturaTextBox
            // 
            this.EstaturaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstaturaTextBox.Location = new System.Drawing.Point(40, 71);
            this.EstaturaTextBox.Multiline = true;
            this.EstaturaTextBox.Name = "EstaturaTextBox";
            this.EstaturaTextBox.Size = new System.Drawing.Size(163, 26);
            this.EstaturaTextBox.TabIndex = 1;
            // 
            // MasaTextBox
            // 
            this.MasaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasaTextBox.Location = new System.Drawing.Point(257, 71);
            this.MasaTextBox.Multiline = true;
            this.MasaTextBox.Name = "MasaTextBox";
            this.MasaTextBox.Size = new System.Drawing.Size(163, 26);
            this.MasaTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(254, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Escribe tu masa (kg):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadoraIMC.Properties.Resources.usuario1;
            this.pictureBox1.Location = new System.Drawing.Point(40, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarButton.FlatAppearance.BorderSize = 0;
            this.LimpiarButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LimpiarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LimpiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarButton.Image = global::CalculadoraIMC.Properties.Resources.limpiar1;
            this.LimpiarButton.Location = new System.Drawing.Point(288, 125);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(89, 50);
            this.LimpiarButton.TabIndex = 4;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // DiagnosticarButton
            // 
            this.DiagnosticarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagnosticarButton.FlatAppearance.BorderSize = 0;
            this.DiagnosticarButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DiagnosticarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DiagnosticarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiagnosticarButton.Image = global::CalculadoraIMC.Properties.Resources.diagnosticar1;
            this.DiagnosticarButton.Location = new System.Drawing.Point(77, 125);
            this.DiagnosticarButton.Name = "DiagnosticarButton";
            this.DiagnosticarButton.Size = new System.Drawing.Size(89, 50);
            this.DiagnosticarButton.TabIndex = 3;
            this.DiagnosticarButton.UseVisualStyleBackColor = true;
            this.DiagnosticarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiagnosticoTextBox
            // 
            this.DiagnosticoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticoTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DiagnosticoTextBox.Location = new System.Drawing.Point(149, 30);
            this.DiagnosticoTextBox.Multiline = true;
            this.DiagnosticoTextBox.Name = "DiagnosticoTextBox";
            this.DiagnosticoTextBox.Size = new System.Drawing.Size(287, 133);
            this.DiagnosticoTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 493);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox MasaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EstaturaTextBox;
        private System.Windows.Forms.Button DiagnosticarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox DiagnosticoTextBox;
    }
}

