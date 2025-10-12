namespace WindowsFormsApp1
{
    partial class GestionarPagosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pagarCuotaBtn = new System.Windows.Forms.Button();
            this.cuotasDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cuotasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de Cuotas";
            // 
            // pagarCuotaBtn
            // 
            this.pagarCuotaBtn.Location = new System.Drawing.Point(92, 451);
            this.pagarCuotaBtn.Name = "pagarCuotaBtn";
            this.pagarCuotaBtn.Size = new System.Drawing.Size(156, 23);
            this.pagarCuotaBtn.TabIndex = 2;
            this.pagarCuotaBtn.Text = "Pagar Cuota Seleccionada";
            this.pagarCuotaBtn.UseVisualStyleBackColor = true;
            this.pagarCuotaBtn.Click += new System.EventHandler(this.pagarCuotaBtn_Click);

            // --- SECCIÓN CORREGIDA ---
            // 1. Primero se configuran las columnas individuales
            // 
            // Column1 (N° Cuota)
            // 
            this.Column1.DataPropertyName = "NumeroCuota";
            this.Column1.HeaderText = "N° Cuota";
            this.Column1.Name = "Column1";
            // 
            // Column2 (Estado)
            // 
            this.Column2.DataPropertyName = "Estado";
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            // 
            // Column3 (Vencimiento)
            // 
            this.Column3.DataPropertyName = "FechaVencimiento";
            this.Column3.HeaderText = "Vencimiento";
            this.Column3.Name = "Column3";
            // 
            // Column4 (Monto)
            // 
            this.Column4.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Format = "C2";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = " Monto";
            this.Column4.Name = "Column4";
            // 
            // 2. Después se configura el DataGridView y SE AÑADEN las columnas ya configuradas
            //
            // cuotasDataGridView
            // 
            this.cuotasDataGridView.AllowUserToAddRows = false; // Buena práctica añadir esto
            this.cuotasDataGridView.AllowUserToDeleteRows = false; // Buena práctica añadir esto
            this.cuotasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cuotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.cuotasDataGridView.Location = new System.Drawing.Point(12, 81);
            this.cuotasDataGridView.Name = "cuotasDataGridView";
            this.cuotasDataGridView.ReadOnly = true; // Buena práctica añadir esto
            this.cuotasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Es más intuitivo
            this.cuotasDataGridView.Size = new System.Drawing.Size(838, 336);
            this.cuotasDataGridView.TabIndex = 3;
            // --- FIN SECCIÓN CORREGIDA ---
            // 
            // GestionarPagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 520);
            this.Controls.Add(this.cuotasDataGridView);
            this.Controls.Add(this.pagarCuotaBtn);
            this.Controls.Add(this.label1);
            this.Name = "GestionarPagosForm";
            this.Text = "GestionarPagosForm";
            this.Load += new System.EventHandler(this.GestionarPagosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuotasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pagarCuotaBtn;
        private System.Windows.Forms.DataGridView cuotasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}