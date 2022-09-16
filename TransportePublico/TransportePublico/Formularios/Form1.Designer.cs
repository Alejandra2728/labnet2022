namespace TransportePublico
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOmnibus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaxi = new System.Windows.Forms.TextBox();
            this.btnAgregarPasajeros = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDatosPasajeros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de pasajeros de transportes publico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pasajeros Omnibus";
            // 
            // txtOmnibus
            // 
            this.txtOmnibus.Location = new System.Drawing.Point(408, 133);
            this.txtOmnibus.Name = "txtOmnibus";
            this.txtOmnibus.Size = new System.Drawing.Size(157, 22);
            this.txtOmnibus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pasajeros Taxi";
            // 
            // txtTaxi
            // 
            this.txtTaxi.Location = new System.Drawing.Point(883, 133);
            this.txtTaxi.Name = "txtTaxi";
            this.txtTaxi.Size = new System.Drawing.Size(100, 22);
            this.txtTaxi.TabIndex = 4;
            // 
            // btnAgregarPasajeros
            // 
            this.btnAgregarPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPasajeros.Location = new System.Drawing.Point(510, 214);
            this.btnAgregarPasajeros.Name = "btnAgregarPasajeros";
            this.btnAgregarPasajeros.Size = new System.Drawing.Size(238, 61);
            this.btnAgregarPasajeros.TabIndex = 5;
            this.btnAgregarPasajeros.Text = "Agregar Pasajeros";
            this.btnAgregarPasajeros.UseVisualStyleBackColor = true;
            this.btnAgregarPasajeros.Click += new System.EventHandler(this.btnAgregarPasajeros_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // dgvDatosPasajeros
            // 
            this.dgvDatosPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDatosPasajeros.Location = new System.Drawing.Point(96, 322);
            this.dgvDatosPasajeros.Name = "dgvDatosPasajeros";
            this.dgvDatosPasajeros.RowHeadersWidth = 51;
            this.dgvDatosPasajeros.RowTemplate.Height = 24;
            this.dgvDatosPasajeros.Size = new System.Drawing.Size(1107, 150);
            this.dgvDatosPasajeros.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pasajeros Omnibus";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Avanzo Omnibus";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Detenerse Omnibus";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pasajeros Taxi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Avanzo Omnibus";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Detenerse Taxi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 527);
            this.Controls.Add(this.dgvDatosPasajeros);
            this.Controls.Add(this.btnAgregarPasajeros);
            this.Controls.Add(this.txtTaxi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOmnibus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "App Transporte Publico";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOmnibus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaxi;
        private System.Windows.Forms.Button btnAgregarPasajeros;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.DataGridView dgvDatosPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

