namespace ControlAutobuses
{
    partial class AutobusForm
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnAgregarAutobus = new System.Windows.Forms.Button();
            this.dataGridViewAutobuses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutobuses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.BackColor = System.Drawing.Color.Lavender;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(61, 215);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(126, 30);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(207, 216);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(204, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(207, 251);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(204, 22);
            this.txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Lavender;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(61, 250);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(126, 30);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(207, 290);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(204, 22);
            this.txtPlaca.TabIndex = 5;
            // 
            // lblPlaca
            // 
            this.lblPlaca.BackColor = System.Drawing.Color.Lavender;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(61, 290);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(126, 30);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlaca.Click += new System.EventHandler(this.lblPlaca_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(207, 329);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(204, 22);
            this.txtColor.TabIndex = 7;
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Lavender;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(61, 328);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(126, 30);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(207, 367);
            this.txtAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(204, 22);
            this.txtAño.TabIndex = 9;
            // 
            // lblAño
            // 
            this.lblAño.BackColor = System.Drawing.Color.Lavender;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(61, 367);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(126, 30);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año:";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAño.Click += new System.EventHandler(this.lblAño_Click);
            // 
            // btnAgregarAutobus
            // 
            this.btnAgregarAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutobus.Location = new System.Drawing.Point(131, 440);
            this.btnAgregarAutobus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarAutobus.Name = "btnAgregarAutobus";
            this.btnAgregarAutobus.Size = new System.Drawing.Size(215, 46);
            this.btnAgregarAutobus.TabIndex = 10;
            this.btnAgregarAutobus.Text = "Agregar Autobús";
            this.btnAgregarAutobus.UseVisualStyleBackColor = true;
            this.btnAgregarAutobus.Click += new System.EventHandler(this.btnAgregarAutobus_Click);
            // 
            // dataGridViewAutobuses
            // 
            this.dataGridViewAutobuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutobuses.Location = new System.Drawing.Point(458, 190);
            this.dataGridViewAutobuses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAutobuses.Name = "dataGridViewAutobuses";
            this.dataGridViewAutobuses.RowHeadersWidth = 51;
            this.dataGridViewAutobuses.Size = new System.Drawing.Size(868, 352);
            this.dataGridViewAutobuses.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 77);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registro de Autobuses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1371, 591);
            this.label1.TabIndex = 13;
            // 
            // AutobusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAutobuses);
            this.Controls.Add(this.btnAgregarAutobus);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AutobusForm";
            this.Text = "AutobusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutobuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Button btnAgregarAutobus;
        private System.Windows.Forms.DataGridView dataGridViewAutobuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}