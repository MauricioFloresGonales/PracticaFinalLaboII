
namespace SimuladorForm
{
    partial class SimulacionForm
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
            this.lblPoblacionEva = new System.Windows.Forms.Label();
            this.lblMicro = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cmbMircro = new System.Windows.Forms.ComboBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.rtxEvolucion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPoblacionEva
            // 
            this.lblPoblacionEva.AutoSize = true;
            this.lblPoblacionEva.Location = new System.Drawing.Point(12, 9);
            this.lblPoblacionEva.Name = "lblPoblacionEva";
            this.lblPoblacionEva.Size = new System.Drawing.Size(110, 15);
            this.lblPoblacionEva.TabIndex = 0;
            this.lblPoblacionEva.Text = "Poblacion a evaluar";
            // 
            // lblMicro
            // 
            this.lblMicro.AutoSize = true;
            this.lblMicro.Location = new System.Drawing.Point(12, 48);
            this.lblMicro.Name = "lblMicro";
            this.lblMicro.Size = new System.Drawing.Size(101, 15);
            this.lblMicro.TabIndex = 1;
            this.lblMicro.Text = "Microorganismo :";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(426, 23);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cmbMircro
            // 
            this.cmbMircro.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMircro.FormattingEnabled = true;
            this.cmbMircro.Items.AddRange(new object[] {
            "Covid-19",
            "Gripe"});
            this.cmbMircro.Location = new System.Drawing.Point(128, 40);
            this.cmbMircro.Name = "cmbMircro";
            this.cmbMircro.Size = new System.Drawing.Size(218, 23);
            this.cmbMircro.TabIndex = 3;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(128, 6);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(218, 23);
            this.txtPoblacion.TabIndex = 4;
            // 
            // rtxEvolucion
            // 
            this.rtxEvolucion.Location = new System.Drawing.Point(12, 83);
            this.rtxEvolucion.Name = "rtxEvolucion";
            this.rtxEvolucion.Size = new System.Drawing.Size(489, 355);
            this.rtxEvolucion.TabIndex = 5;
            this.rtxEvolucion.Text = "";
            // 
            // SimulacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.rtxEvolucion);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.cmbMircro);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lblMicro);
            this.Controls.Add(this.lblPoblacionEva);
            this.Name = "SimulacionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoblacionEva;
        private System.Windows.Forms.Label lblMicro;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ComboBox cmbMircro;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.RichTextBox rtxEvolucion;
    }
}

