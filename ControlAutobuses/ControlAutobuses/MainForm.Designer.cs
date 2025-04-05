namespace ControlAutobuses
{
    partial class MainForm
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
            this.btnChoferForm = new System.Windows.Forms.Button();
            this.btnAutobusForm = new System.Windows.Forms.Button();
            this.btnRutaForm = new System.Windows.Forms.Button();
            this.btnAsignacionForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 269);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoferForm
            // 
            this.btnChoferForm.Location = new System.Drawing.Point(58, 173);
            this.btnChoferForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoferForm.Name = "btnChoferForm";
            this.btnChoferForm.Size = new System.Drawing.Size(163, 41);
            this.btnChoferForm.TabIndex = 2;
            this.btnChoferForm.Text = "Registrar Choferes";
            this.btnChoferForm.UseVisualStyleBackColor = true;
            this.btnChoferForm.Click += new System.EventHandler(this.btnChoferForm_Click);
            // 
            // btnAutobusForm
            // 
            this.btnAutobusForm.Location = new System.Drawing.Point(242, 173);
            this.btnAutobusForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutobusForm.Name = "btnAutobusForm";
            this.btnAutobusForm.Size = new System.Drawing.Size(163, 41);
            this.btnAutobusForm.TabIndex = 3;
            this.btnAutobusForm.Text = "Registrar Autobuses";
            this.btnAutobusForm.UseVisualStyleBackColor = true;
            this.btnAutobusForm.Click += new System.EventHandler(this.btnAutobusForm_Click);
            // 
            // btnRutaForm
            // 
            this.btnRutaForm.Location = new System.Drawing.Point(425, 173);
            this.btnRutaForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRutaForm.Name = "btnRutaForm";
            this.btnRutaForm.Size = new System.Drawing.Size(163, 41);
            this.btnRutaForm.TabIndex = 4;
            this.btnRutaForm.Text = "Registrar Rutas";
            this.btnRutaForm.UseVisualStyleBackColor = true;
            this.btnRutaForm.Click += new System.EventHandler(this.btnRutaForm_Click);
            // 
            // btnAsignacionForm
            // 
            this.btnAsignacionForm.Location = new System.Drawing.Point(605, 173);
            this.btnAsignacionForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignacionForm.Name = "btnAsignacionForm";
            this.btnAsignacionForm.Size = new System.Drawing.Size(220, 41);
            this.btnAsignacionForm.TabIndex = 5;
            this.btnAsignacionForm.Text = "Asignar Choferes y Autobuses";
            this.btnAsignacionForm.UseVisualStyleBackColor = true;
            this.btnAsignacionForm.Click += new System.EventHandler(this.btnAsignacionForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 269);
            this.Controls.Add(this.btnAsignacionForm);
            this.Controls.Add(this.btnRutaForm);
            this.Controls.Add(this.btnAutobusForm);
            this.Controls.Add(this.btnChoferForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoferForm;
        private System.Windows.Forms.Button btnAutobusForm;
        private System.Windows.Forms.Button btnRutaForm;
        private System.Windows.Forms.Button btnAsignacionForm;
    }
}

