namespace WindowsFormsApp1
{
    partial class Préstamo_System
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoCuotaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.fechaInicioPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cuotasTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agregarClienteBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPrestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAdeudado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionarPagosBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.verReportesBtn = new System.Windows.Forms.Button();
            this.darDeBajaBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tipoCuotaComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.aceptarBtn);
            this.groupBox1.Controls.Add(this.fechaInicioPicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cuotasTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.montoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.agregarClienteBtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Préstamo";
            // 
            // tipoCuotaComboBox
            // 
            this.tipoCuotaComboBox.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.tipoCuotaComboBox.FormattingEnabled = true;
            this.tipoCuotaComboBox.Location = new System.Drawing.Point(286, 135);
            this.tipoCuotaComboBox.Name = "tipoCuotaComboBox";
            this.tipoCuotaComboBox.Size = new System.Drawing.Size(219, 26);
            this.tipoCuotaComboBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.label6.Location = new System.Drawing.Point(67, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tipo de Préstamo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.label7.Location = new System.Drawing.Point(1078, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 90);
            this.label7.TabIndex = 15;
            this.label7.Text = "Al hacer click en el siguiente\r\nbotón, agregará un nuevo\r\nprestamo a la lista de " +
    "préstamos.\r\nPor favor corrobore que los datos\r\ningresados sean correctos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(1155, 138);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 39);
            this.aceptarBtn.TabIndex = 14;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // fechaInicioPicker
            // 
            this.fechaInicioPicker.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.fechaInicioPicker.Location = new System.Drawing.Point(305, 97);
            this.fechaInicioPicker.Name = "fechaInicioPicker";
            this.fechaInicioPicker.Size = new System.Drawing.Size(200, 25);
            this.fechaInicioPicker.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.label5.Location = new System.Drawing.Point(67, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Inicio del prestamo:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(759, 140);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 25);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tasa de Interés:";
            // 
            // cuotasTextBox
            // 
            this.cuotasTextBox.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.cuotasTextBox.Location = new System.Drawing.Point(759, 97);
            this.cuotasTextBox.Name = "cuotasTextBox";
            this.cuotasTextBox.Size = new System.Drawing.Size(185, 25);
            this.cuotasTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(613, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de Cuotas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // montoTextBox
            // 
            this.montoTextBox.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.montoTextBox.Location = new System.Drawing.Point(759, 54);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(185, 25);
            this.montoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto a prestar:";
            // 
            // agregarClienteBtn
            // 
            this.agregarClienteBtn.Location = new System.Drawing.Point(421, 52);
            this.agregarClienteBtn.Name = "agregarClienteBtn";
            this.agregarClienteBtn.Size = new System.Drawing.Size(84, 27);
            this.agregarClienteBtn.TabIndex = 3;
            this.agregarClienteBtn.Text = "Agregar";
            this.agregarClienteBtn.UseVisualStyleBackColor = true;
            this.agregarClienteBtn.Click += new System.EventHandler(this.agregarClienteBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 26);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.MontoPrestado,
            this.MontoAdeudado});
            this.dataGridView1.Location = new System.Drawing.Point(11, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 383);
            this.dataGridView1.TabIndex = 1;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // MontoPrestado
            // 
            this.MontoPrestado.DataPropertyName = "MontoPrestado";
            dataGridViewCellStyle1.Format = "C2";
            this.MontoPrestado.DefaultCellStyle = dataGridViewCellStyle1;
            this.MontoPrestado.HeaderText = "Monto Prestado";
            this.MontoPrestado.Name = "MontoPrestado";
            this.MontoPrestado.ReadOnly = true;
            // 
            // MontoAdeudado
            // 
            this.MontoAdeudado.DataPropertyName = "MontoAdeudado";
            dataGridViewCellStyle2.Format = "C2";
            this.MontoAdeudado.DefaultCellStyle = dataGridViewCellStyle2;
            this.MontoAdeudado.HeaderText = " Monto Adeudado";
            this.MontoAdeudado.Name = "MontoAdeudado";
            this.MontoAdeudado.ReadOnly = true;
            // 
            // gestionarPagosBtn
            // 
            this.gestionarPagosBtn.Location = new System.Drawing.Point(1233, 309);
            this.gestionarPagosBtn.Name = "gestionarPagosBtn";
            this.gestionarPagosBtn.Size = new System.Drawing.Size(99, 44);
            this.gestionarPagosBtn.TabIndex = 2;
            this.gestionarPagosBtn.Text = "Gestionar Pagos";
            this.gestionarPagosBtn.UseVisualStyleBackColor = true;
            this.gestionarPagosBtn.Click += new System.EventHandler(this.gestionarPagosBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(586, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sistema de Préstamos";
            // 
            // verReportesBtn
            // 
            this.verReportesBtn.Location = new System.Drawing.Point(1233, 413);
            this.verReportesBtn.Name = "verReportesBtn";
            this.verReportesBtn.Size = new System.Drawing.Size(99, 32);
            this.verReportesBtn.TabIndex = 17;
            this.verReportesBtn.Text = "Ver Reportes";
            this.verReportesBtn.UseVisualStyleBackColor = true;
            this.verReportesBtn.Click += new System.EventHandler(this.verReportesBtn_Click);
            // 
            // darDeBajaBtn
            // 
            this.darDeBajaBtn.Location = new System.Drawing.Point(1233, 359);
            this.darDeBajaBtn.Name = "darDeBajaBtn";
            this.darDeBajaBtn.Size = new System.Drawing.Size(99, 44);
            this.darDeBajaBtn.TabIndex = 18;
            this.darDeBajaBtn.Text = "Dar de Baja Préstamo";
            this.darDeBajaBtn.UseVisualStyleBackColor = true;
            this.darDeBajaBtn.Click += new System.EventHandler(this.darDeBajaBtn_Click);
            // 
            // Préstamo_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.darDeBajaBtn);
            this.Controls.Add(this.verReportesBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gestionarPagosBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Préstamo_System";
            this.Text = "Préstamo_System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarClienteBtn;
        private System.Windows.Forms.TextBox cuotasTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaInicioPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPrestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAdeudado;
        private System.Windows.Forms.Button gestionarPagosBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button verReportesBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoCuotaComboBox;
        private System.Windows.Forms.Button darDeBajaBtn;
    }
}

