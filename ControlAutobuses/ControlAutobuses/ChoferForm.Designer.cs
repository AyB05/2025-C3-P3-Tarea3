namespace ControlAutobuses
{
    partial class ChoferForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarChofer = new System.Windows.Forms.Button();
            this.lblNombreChofer = new System.Windows.Forms.Label();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.txtApellidoChofer = new System.Windows.Forms.TextBox();
            this.lblApellidoChofer = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblCedulaChofer = new System.Windows.Forms.Label();
            this.txtCedulaChofer = new System.Windows.Forms.TextBox();
            this.dataGridViewChoferes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarChofer.Location = new System.Drawing.Point(152, 392);
            this.btnAgregarChofer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(217, 47);
            this.btnAgregarChofer.TabIndex = 0;
            this.btnAgregarChofer.Text = "Agregar Chofer";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.BackColor = System.Drawing.Color.Lavender;
            this.lblNombreChofer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChofer.Location = new System.Drawing.Point(31, 169);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(174, 30);
            this.lblNombreChofer.TabIndex = 1;
            this.lblNombreChofer.Text = "Nombre chofer:";
            this.lblNombreChofer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Location = new System.Drawing.Point(211, 171);
            this.txtNombreChofer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.Size = new System.Drawing.Size(263, 22);
            this.txtNombreChofer.TabIndex = 2;
            // 
            // txtApellidoChofer
            // 
            this.txtApellidoChofer.Location = new System.Drawing.Point(211, 213);
            this.txtApellidoChofer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoChofer.Name = "txtApellidoChofer";
            this.txtApellidoChofer.Size = new System.Drawing.Size(263, 22);
            this.txtApellidoChofer.TabIndex = 4;
            // 
            // lblApellidoChofer
            // 
            this.lblApellidoChofer.BackColor = System.Drawing.Color.Lavender;
            this.lblApellidoChofer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellidoChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChofer.Location = new System.Drawing.Point(31, 208);
            this.lblApellidoChofer.Name = "lblApellidoChofer";
            this.lblApellidoChofer.Size = new System.Drawing.Size(174, 30);
            this.lblApellidoChofer.TabIndex = 3;
            this.lblApellidoChofer.Text = "Apellido chofer:";
            this.lblApellidoChofer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Lavender;
            this.lblFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(31, 248);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(174, 30);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha nacimiento:";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(211, 258);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(263, 22);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // lblCedulaChofer
            // 
            this.lblCedulaChofer.BackColor = System.Drawing.Color.Lavender;
            this.lblCedulaChofer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCedulaChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaChofer.Location = new System.Drawing.Point(31, 292);
            this.lblCedulaChofer.Name = "lblCedulaChofer";
            this.lblCedulaChofer.Size = new System.Drawing.Size(174, 30);
            this.lblCedulaChofer.TabIndex = 7;
            this.lblCedulaChofer.Text = "Cedula:";
            this.lblCedulaChofer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCedulaChofer
            // 
            this.txtCedulaChofer.Location = new System.Drawing.Point(211, 297);
            this.txtCedulaChofer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedulaChofer.Name = "txtCedulaChofer";
            this.txtCedulaChofer.Size = new System.Drawing.Size(263, 22);
            this.txtCedulaChofer.TabIndex = 8;
            // 
            // dataGridViewChoferes
            // 
            this.dataGridViewChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoferes.Location = new System.Drawing.Point(502, 169);
            this.dataGridViewChoferes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewChoferes.Name = "dataGridViewChoferes";
            this.dataGridViewChoferes.RowHeadersWidth = 51;
            this.dataGridViewChoferes.Size = new System.Drawing.Size(737, 374);
            this.dataGridViewChoferes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1272, 614);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 77);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registro de choferes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewChoferes);
            this.Controls.Add(this.txtCedulaChofer);
            this.Controls.Add(this.lblCedulaChofer);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtApellidoChofer);
            this.Controls.Add(this.lblApellidoChofer);
            this.Controls.Add(this.txtNombreChofer);
            this.Controls.Add(this.lblNombreChofer);
            this.Controls.Add(this.btnAgregarChofer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChoferForm";
            this.Text = "ChoferForm";
            this.Load += new System.EventHandler(this.ChoferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarChofer;
        private System.Windows.Forms.Label lblNombreChofer;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.TextBox txtApellidoChofer;
        private System.Windows.Forms.Label lblApellidoChofer;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblCedulaChofer;
        private System.Windows.Forms.TextBox txtCedulaChofer;
        private System.Windows.Forms.DataGridView dataGridViewChoferes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}