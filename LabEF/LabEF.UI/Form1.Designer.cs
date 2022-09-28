namespace LabEF.UI
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
            this.dtvMostrarDato = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this._RegType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RegStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarDato)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvMostrarDato
            // 
            this.dtvMostrarDato.AllowUserToAddRows = false;
            this.dtvMostrarDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMostrarDato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._RegType,
            this._RegStatus});
            this.dtvMostrarDato.Location = new System.Drawing.Point(12, 45);
            this.dtvMostrarDato.Name = "dtvMostrarDato";
            this.dtvMostrarDato.RowHeadersWidth = 51;
            this.dtvMostrarDato.RowTemplate.Height = 24;
            this.dtvMostrarDato.Size = new System.Drawing.Size(1118, 400);
            this.dtvMostrarDato.TabIndex = 0;
            this.dtvMostrarDato.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMostrarDato_CellEndEdit);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(140, 464);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 34);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // _RegType
            // 
            this._RegType.HeaderText = "_RegType";
            this._RegType.MinimumWidth = 6;
            this._RegType.Name = "_RegType";
            this._RegType.ReadOnly = true;
            this._RegType.Width = 125;
            // 
            // _RegStatus
            // 
            this._RegStatus.HeaderText = "_RegStatus";
            this._RegStatus.MinimumWidth = 6;
            this._RegStatus.Name = "_RegStatus";
            this._RegStatus.ReadOnly = true;
            this._RegStatus.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(522, 464);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(939, 464);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 34);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 510);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtvMostrarDato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarDato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvMostrarDato;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RegType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RegStatus;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

