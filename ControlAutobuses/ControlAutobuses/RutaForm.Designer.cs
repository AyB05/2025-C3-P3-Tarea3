namespace ControlAutobuses
{
    partial class RutaForm
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
            this.lblNombreRuta = new System.Windows.Forms.Label();
            this.txtNombreRuta = new System.Windows.Forms.TextBox();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.dataGridViewRutas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreRuta
            // 
            this.lblNombreRuta.BackColor = System.Drawing.Color.Lavender;
            this.lblNombreRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRuta.Location = new System.Drawing.Point(40, 229);
            this.lblNombreRuta.Name = "lblNombreRuta";
            this.lblNombreRuta.Size = new System.Drawing.Size(142, 30);
            this.lblNombreRuta.TabIndex = 0;
            this.lblNombreRuta.Text = "Nombre ruta:";
            this.lblNombreRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreRuta.Click += new System.EventHandler(this.lblNombreRuta_Click);
            // 
            // txtNombreRuta
            // 
            this.txtNombreRuta.Location = new System.Drawing.Point(188, 234);
            this.txtNombreRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRuta.Name = "txtNombreRuta";
            this.txtNombreRuta.Size = new System.Drawing.Size(221, 22);
            this.txtNombreRuta.TabIndex = 1;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.Location = new System.Drawing.Point(134, 314);
            this.btnAgregarRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(205, 41);
            this.btnAgregarRuta.TabIndex = 2;
            this.btnAgregarRuta.Text = "Agregar Ruta";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // dataGridViewRutas
            // 
            this.dataGridViewRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRutas.Location = new System.Drawing.Point(459, 151);
            this.dataGridViewRutas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRutas.Name = "dataGridViewRutas";
            this.dataGridViewRutas.RowHeadersWidth = 51;
            this.dataGridViewRutas.Size = new System.Drawing.Size(340, 353);
            this.dataGridViewRutas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 535);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "Registro de Rutas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RutaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRutas);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.txtNombreRuta);
            this.Controls.Add(this.lblNombreRuta);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RutaForm";
            this.Text = "RutaForm";
            this.Load += new System.EventHandler(this.RutaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreRuta;
        private System.Windows.Forms.TextBox txtNombreRuta;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.DataGridView dataGridViewRutas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}