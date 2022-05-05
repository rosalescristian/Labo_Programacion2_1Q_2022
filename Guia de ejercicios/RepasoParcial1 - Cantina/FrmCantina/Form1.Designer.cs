namespace FrmCantina
{
    partial class FrmCantina
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cBoxBotella = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rBtnCerveza = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.rBtnAgua = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(247, 291);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 23);
            this.textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(247, 362);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cBoxBotella
            // 
            this.cBoxBotella.FormattingEnabled = true;
            this.cBoxBotella.Location = new System.Drawing.Point(528, 309);
            this.cBoxBotella.Name = "cBoxBotella";
            this.cBoxBotella.Size = new System.Drawing.Size(121, 23);
            this.cBoxBotella.TabIndex = 3;
            this.cBoxBotella.SelectedIndexChanged += new System.EventHandler(this.cBoxBotella_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(528, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 41);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // rBtnCerveza
            // 
            this.rBtnCerveza.AutoSize = true;
            this.rBtnCerveza.Location = new System.Drawing.Point(44, 313);
            this.rBtnCerveza.Name = "rBtnCerveza";
            this.rBtnCerveza.Size = new System.Drawing.Size(66, 19);
            this.rBtnCerveza.TabIndex = 5;
            this.rBtnCerveza.TabStop = true;
            this.rBtnCerveza.Text = "Cerveza";
            this.rBtnCerveza.UseVisualStyleBackColor = true;
            this.rBtnCerveza.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(373, 362);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 6;
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(528, 291);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(69, 15);
            this.lblBotellaTipo.TabIndex = 7;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(247, 344);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(63, 15);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(373, 344);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(63, 15);
            this.lblContenido.TabIndex = 9;
            this.lblContenido.Text = "Contenido";
            // 
            // rBtnAgua
            // 
            this.rBtnAgua.AutoSize = true;
            this.rBtnAgua.Location = new System.Drawing.Point(44, 344);
            this.rBtnAgua.Name = "rBtnAgua";
            this.rBtnAgua.Size = new System.Drawing.Size(53, 19);
            this.rBtnAgua.TabIndex = 10;
            this.rBtnAgua.TabStop = true;
            this.rBtnAgua.Text = "Agua";
            this.rBtnAgua.UseVisualStyleBackColor = true;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtnAgua);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.rBtnCerveza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cBoxBotella);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMarca);
            this.Name = "FrmCantina";
            this.Text = "RosalesCristian2C";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cBoxBotella;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rBtnCerveza;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.RadioButton rBtnAgua;
    }
}
