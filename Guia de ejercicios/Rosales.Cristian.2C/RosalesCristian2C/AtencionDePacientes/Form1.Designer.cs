namespace AtencionDePacientes
{
    partial class Form1
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
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.rtbInfoMedico = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(586, 38);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(128, 60);
            this.btnAtender.TabIndex = 0;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(586, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 60);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(12, 20);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(95, 15);
            this.lblMedicos.TabIndex = 2;
            this.lblMedicos.Text = "Personal medico";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(299, 20);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(57, 15);
            this.lblPacientes.TabIndex = 3;
            this.lblPacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 15;
            this.lstMedicos.Location = new System.Drawing.Point(12, 38);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(281, 244);
            this.lstMedicos.TabIndex = 4;
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(299, 38);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(281, 244);
            this.lstPacientes.TabIndex = 5;
            // 
            // rtbInfoMedico
            // 
            this.rtbInfoMedico.Location = new System.Drawing.Point(12, 288);
            this.rtbInfoMedico.Name = "rtbInfoMedico";
            this.rtbInfoMedico.Size = new System.Drawing.Size(568, 150);
            this.rtbInfoMedico.TabIndex = 6;
            this.rtbInfoMedico.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.rtbInfoMedico);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtender);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RosalesCristian2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.RichTextBox rtbInfoMedico;
    }
}
