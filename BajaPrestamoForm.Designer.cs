namespace WindowsFormsApp1
{
    partial class BajaPrestamoForm
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
            this.errorRadioButton = new System.Windows.Forms.RadioButton();
            this.deudorRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmarBajaBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errorRadioButton
            // 
            this.errorRadioButton.AutoSize = true;
            this.errorRadioButton.Location = new System.Drawing.Point(67, 108);
            this.errorRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.errorRadioButton.Name = "errorRadioButton";
            this.errorRadioButton.Size = new System.Drawing.Size(124, 22);
            this.errorRadioButton.TabIndex = 0;
            this.errorRadioButton.TabStop = true;
            this.errorRadioButton.Text = "Error de Carga";
            this.errorRadioButton.UseVisualStyleBackColor = true;
            // 
            // deudorRadioButton
            // 
            this.deudorRadioButton.AutoSize = true;
            this.deudorRadioButton.Location = new System.Drawing.Point(264, 108);
            this.deudorRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deudorRadioButton.Name = "deudorRadioButton";
            this.deudorRadioButton.Size = new System.Drawing.Size(151, 22);
            this.deudorRadioButton.TabIndex = 1;
            this.deudorRadioButton.TabStop = true;
            this.deudorRadioButton.Text = "Deudor Incobrable";
            this.deudorRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Motivo de la baja del préstamo?";
            // 
            // confirmarBajaBtn
            // 
            this.confirmarBajaBtn.Location = new System.Drawing.Point(225, 173);
            this.confirmarBajaBtn.Name = "confirmarBajaBtn";
            this.confirmarBajaBtn.Size = new System.Drawing.Size(118, 23);
            this.confirmarBajaBtn.TabIndex = 3;
            this.confirmarBajaBtn.Text = "Confirmar Baja";
            this.confirmarBajaBtn.UseVisualStyleBackColor = true;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(130, 173);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 4;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // BajaPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 233);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.confirmarBajaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deudorRadioButton);
            this.Controls.Add(this.errorRadioButton);
            this.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BajaPrestamoForm";
            this.Text = "BajaPrestamoForm";
            this.Load += new System.EventHandler(this.BajaPrestamoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton errorRadioButton;
        private System.Windows.Forms.RadioButton deudorRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmarBajaBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}