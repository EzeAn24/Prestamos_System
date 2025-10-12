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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.agregarClienteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.cuotasTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaInicioPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPrestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAdeudado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionarPagosBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.aceptarBtn);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Préstamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el cliente:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // agregarClienteBtn
            // 
            this.agregarClienteBtn.Location = new System.Drawing.Point(421, 52);
            this.agregarClienteBtn.Name = "agregarClienteBtn";
            this.agregarClienteBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarClienteBtn.TabIndex = 3;
            this.agregarClienteBtn.Text = "Agregar";
            this.agregarClienteBtn.UseVisualStyleBackColor = true;
            this.agregarClienteBtn.Click += new System.EventHandler(this.agregarClienteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto a prestar:";
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(196, 103);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(185, 23);
            this.montoTextBox.TabIndex = 5;
            // 
            // cuotasTextBox
            // 
            this.cuotasTextBox.Location = new System.Drawing.Point(196, 151);
            this.cuotasTextBox.Name = "cuotasTextBox";
            this.cuotasTextBox.Size = new System.Drawing.Size(185, 23);
            this.cuotasTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de Cuotas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tasa de Interés:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 210);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 23);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Inicio del prestamo:";
            // 
            // fechaInicioPicker
            // 
            this.fechaInicioPicker.Location = new System.Drawing.Point(707, 103);
            this.fechaInicioPicker.Name = "fechaInicioPicker";
            this.fechaInicioPicker.Size = new System.Drawing.Size(200, 23);
            this.fechaInicioPicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha posible de finalización de pago:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(773, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 23);
            this.textBox3.TabIndex = 13;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(1079, 214);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 14;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1004, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 75);
            this.label7.TabIndex = 15;
            this.label7.Text = "Al hacer click en el siguiente\r\nbotón, agregará un nuevo\r\nprestamo a la lista de " +
    "préstamos.\r\nPor favor corrobore que los datos\r\ningresados sean correctos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.MontoPrestado,
            this.MontoAdeudado});
            this.dataGridView1.Location = new System.Drawing.Point(15, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1125, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // MontoPrestado
            // 
            this.MontoPrestado.DataPropertyName = "MontoPrestado";
            dataGridViewCellStyle1.Format = "C2";
            this.MontoPrestado.DefaultCellStyle = dataGridViewCellStyle1;
            this.MontoPrestado.HeaderText = "Monto Prestado";
            this.MontoPrestado.Name = "MontoPrestado";
            // 
            // MontoAdeudado
            // 
            this.MontoAdeudado.DataPropertyName = "MontoAdeudado";
            dataGridViewCellStyle2.Format = "C2";
            this.MontoAdeudado.DefaultCellStyle = dataGridViewCellStyle2;
            this.MontoAdeudado.HeaderText = " Monto Adeudado";
            this.MontoAdeudado.Name = "MontoAdeudado";
            // 
            // gestionarPagosBtn
            // 
            this.gestionarPagosBtn.Location = new System.Drawing.Point(1158, 424);
            this.gestionarPagosBtn.Name = "gestionarPagosBtn";
            this.gestionarPagosBtn.Size = new System.Drawing.Size(99, 44);
            this.gestionarPagosBtn.TabIndex = 2;
            this.gestionarPagosBtn.Text = "Gestionar Pagos";
            this.gestionarPagosBtn.UseVisualStyleBackColor = true;
            this.gestionarPagosBtn.Click += new System.EventHandler(this.gestionarPagosBtn_Click);
            // 
            // Préstamo_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPrestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAdeudado;
        private System.Windows.Forms.Button gestionarPagosBtn;
    }
}

