namespace ControlAutobuses
{
    partial class AsignacionForm
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
            this.lblChofer = new System.Windows.Forms.Label();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.lblAutobus = new System.Windows.Forms.Label();
            this.cmbAutobuses = new System.Windows.Forms.ComboBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbRutas = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dataGridViewAsignaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChofer
            // 
            this.lblChofer.BackColor = System.Drawing.Color.Lavender;
            this.lblChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChofer.Location = new System.Drawing.Point(38, 201);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(102, 27);
            this.lblChofer.TabIndex = 0;
            this.lblChofer.Text = "Chofer:";
            this.lblChofer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbChoferes
            // 
            this.cmbChoferes.FormattingEnabled = true;
            this.cmbChoferes.Location = new System.Drawing.Point(146, 199);
            this.cmbChoferes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChoferes.Name = "cmbChoferes";
            this.cmbChoferes.Size = new System.Drawing.Size(288, 24);
            this.cmbChoferes.TabIndex = 1;
            // 
            // lblAutobus
            // 
            this.lblAutobus.BackColor = System.Drawing.Color.Lavender;
            this.lblAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutobus.Location = new System.Drawing.Point(38, 256);
            this.lblAutobus.Name = "lblAutobus";
            this.lblAutobus.Size = new System.Drawing.Size(102, 27);
            this.lblAutobus.TabIndex = 2;
            this.lblAutobus.Text = "Autobus:";
            this.lblAutobus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAutobuses
            // 
            this.cmbAutobuses.FormattingEnabled = true;
            this.cmbAutobuses.Location = new System.Drawing.Point(146, 253);
            this.cmbAutobuses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAutobuses.Name = "cmbAutobuses";
            this.cmbAutobuses.Size = new System.Drawing.Size(288, 24);
            this.cmbAutobuses.TabIndex = 3;
            // 
            // lblRuta
            // 
            this.lblRuta.BackColor = System.Drawing.Color.Lavender;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(38, 309);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(102, 27);
            this.lblRuta.TabIndex = 4;
            this.lblRuta.Text = "Ruta:";
            this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRutas
            // 
            this.cmbRutas.FormattingEnabled = true;
            this.cmbRutas.Location = new System.Drawing.Point(146, 306);
            this.cmbRutas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRutas.Name = "cmbRutas";
            this.cmbRutas.Size = new System.Drawing.Size(288, 24);
            this.cmbRutas.TabIndex = 5;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(179, 375);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(161, 39);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dataGridViewAsignaciones
            // 
            this.dataGridViewAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignaciones.Location = new System.Drawing.Point(489, 199);
            this.dataGridViewAsignaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAsignaciones.Name = "dataGridViewAsignaciones";
            this.dataGridViewAsignaciones.RowHeadersWidth = 51;
            this.dataGridViewAsignaciones.Size = new System.Drawing.Size(609, 330);
            this.dataGridViewAsignaciones.TabIndex = 7;
            this.dataGridViewAsignaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAsignaciones_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1146, 558);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 57);
            this.label2.TabIndex = 16;
            this.label2.Text = "Asignaciones";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AsignacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAsignaciones);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cmbRutas);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.cmbAutobuses);
            this.Controls.Add(this.lblAutobus);
            this.Controls.Add(this.cmbChoferes);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AsignacionForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.Label lblAutobus;
        private System.Windows.Forms.ComboBox cmbAutobuses;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbRutas;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dataGridViewAsignaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}