namespace Vista
{
    partial class FrmTest
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
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbInfoMedico = new System.Windows.Forms.RichTextBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 15;
            this.lstMedicos.Location = new System.Drawing.Point(44, 68);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(254, 289);
            this.lstMedicos.TabIndex = 0;
            this.lstMedicos.SelectedIndexChanged += new System.EventHandler(this.lstMedicos_SelectedIndexChanged);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(341, 68);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(254, 289);
            this.lstPacientes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personal Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pacientes";
            // 
            // rtbInfoMedico
            // 
            this.rtbInfoMedico.Location = new System.Drawing.Point(50, 399);
            this.rtbInfoMedico.Name = "rtbInfoMedico";
            this.rtbInfoMedico.Size = new System.Drawing.Size(545, 96);
            this.rtbInfoMedico.TabIndex = 4;
            this.rtbInfoMedico.Text = "";
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(623, 85);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 23);
            this.btnAtender.TabIndex = 5;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(629, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.rtbInfoMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.lstMedicos);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTest_FormClosing);
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbInfoMedico;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnSalir;
    }
}
