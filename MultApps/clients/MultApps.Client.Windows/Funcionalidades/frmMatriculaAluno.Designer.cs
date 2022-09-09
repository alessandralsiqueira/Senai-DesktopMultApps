namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatriculaAluno));
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnomecx = new System.Windows.Forms.TextBox();
            this.lblanonascimento = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.lblultimoaniversario = new System.Windows.Forms.Label();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.btnidentificar = new System.Windows.Forms.Button();
            this.lblamarelo = new System.Windows.Forms.Label();
            this.lblCategoriaText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnome.Location = new System.Drawing.Point(12, 24);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(53, 23);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "&Nome:";
            this.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnomecx
            // 
            this.txtnomecx.Location = new System.Drawing.Point(57, 24);
            this.txtnomecx.Name = "txtnomecx";
            this.txtnomecx.Size = new System.Drawing.Size(340, 23);
            this.txtnomecx.TabIndex = 1;
            // 
            // lblanonascimento
            // 
            this.lblanonascimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblanonascimento.Location = new System.Drawing.Point(12, 64);
            this.lblanonascimento.Name = "lblanonascimento";
            this.lblanonascimento.Size = new System.Drawing.Size(108, 23);
            this.lblanonascimento.TabIndex = 2;
            this.lblanonascimento.Text = "&Ano Nascimento:";
            this.lblanonascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(112, 64);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(64, 23);
            this.txtAnoNascimento.TabIndex = 3;
            // 
            // lblultimoaniversario
            // 
            this.lblultimoaniversario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblultimoaniversario.Location = new System.Drawing.Point(198, 64);
            this.lblultimoaniversario.Name = "lblultimoaniversario";
            this.lblultimoaniversario.Size = new System.Drawing.Size(141, 23);
            this.lblultimoaniversario.TabIndex = 4;
            this.lblultimoaniversario.Text = "An&o Último Aniversário:";
            this.lblultimoaniversario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(333, 64);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(64, 23);
            this.txtAnoUltimoAniversario.TabIndex = 5;
            this.txtAnoUltimoAniversario.Enter += new System.EventHandler(this.txtultimoanivrsario_Enter);
            // 
            // lblcategoria
            // 
            this.lblcategoria.Location = new System.Drawing.Point(167, 108);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(73, 19);
            this.lblcategoria.TabIndex = 7;
            this.lblcategoria.Text = "Categoria:";
            // 
            // btnidentificar
            // 
            this.btnidentificar.Location = new System.Drawing.Point(19, 104);
            this.btnidentificar.Name = "btnidentificar";
            this.btnidentificar.Size = new System.Drawing.Size(142, 23);
            this.btnidentificar.TabIndex = 8;
            this.btnidentificar.Text = "Identificar Categoria";
            this.btnidentificar.UseVisualStyleBackColor = true;
            // 
            // lblamarelo
            // 
            this.lblamarelo.AutoSize = true;
            this.lblamarelo.BackColor = System.Drawing.Color.Yellow;
            this.lblamarelo.Location = new System.Drawing.Point(246, 123);
            this.lblamarelo.Name = "lblamarelo";
            this.lblamarelo.Size = new System.Drawing.Size(0, 15);
            this.lblamarelo.TabIndex = 9;
            // 
            // lblCategoriaText
            // 
            this.lblCategoriaText.BackColor = System.Drawing.Color.Yellow;
            this.lblCategoriaText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoriaText.Location = new System.Drawing.Point(230, 104);
            this.lblCategoriaText.Name = "lblCategoriaText";
            this.lblCategoriaText.Size = new System.Drawing.Size(167, 23);
            this.lblCategoriaText.TabIndex = 10;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(409, 139);
            this.Controls.Add(this.lblCategoriaText);
            this.Controls.Add(this.lblamarelo);
            this.Controls.Add(this.btnidentificar);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.lblultimoaniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lblanonascimento);
            this.Controls.Add(this.txtnomecx);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMatriculaAluno";
            this.Text = "Matrícula de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnome;
        private TextBox txtnomecx;
        private Label lblanonascimento;
        private TextBox txtAnoNascimento;
        private Label lblultimoaniversario;
        private TextBox txtAnoUltimoAniversario;
        private Label lblcategoria;
        private Button btnidentificar;
        private Label lblamarelo;
        private Label lblCategoriaText;
    }
}