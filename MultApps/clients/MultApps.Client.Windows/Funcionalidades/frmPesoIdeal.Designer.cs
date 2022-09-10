namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmPesoIdeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesoIdeal));
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.btnMasculino = new System.Windows.Forms.RadioButton();
            this.btnFeminino = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.btnFeminino);
            this.gbxSexo.Controls.Add(this.btnMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(21, 29);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(220, 57);
            this.gbxSexo.TabIndex = 0;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // btnMasculino
            // 
            this.btnMasculino.AutoSize = true;
            this.btnMasculino.Checked = true;
            this.btnMasculino.Location = new System.Drawing.Point(16, 22);
            this.btnMasculino.Name = "btnMasculino";
            this.btnMasculino.Size = new System.Drawing.Size(80, 19);
            this.btnMasculino.TabIndex = 0;
            this.btnMasculino.TabStop = true;
            this.btnMasculino.Text = "Masculino";
            this.btnMasculino.UseVisualStyleBackColor = true;
            // 
            // btnFeminino
            // 
            this.btnFeminino.AutoSize = true;
            this.btnFeminino.Location = new System.Drawing.Point(128, 22);
            this.btnFeminino.Name = "btnFeminino";
            this.btnFeminino.Size = new System.Drawing.Size(75, 19);
            this.btnFeminino.TabIndex = 1;
            this.btnFeminino.Text = "Feminino";
            this.btnFeminino.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(247, 33);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(42, 15);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(247, 51);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(66, 23);
            this.txtAltura.TabIndex = 2;
            // 
            // frmPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 184);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.gbxSexo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesoIdeal";
            this.Text = "Cálculo do Peso Ideal";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbxSexo;
        private RadioButton btnFeminino;
        private RadioButton btnMasculino;
        private Label lblAltura;
        private TextBox txtAltura;
    }
}