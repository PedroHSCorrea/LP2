namespace Psalario
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nupdFilhos = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtAliqINSS = new System.Windows.Forms.TextBox();
            this.txtAliqIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFam = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.butVerificar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupdFilhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(152, 68);
            this.mskbxSalario.Mask = "90000.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(171, 20);
            this.mskbxSalario.TabIndex = 0;
            this.mskbxSalario.Validated += new System.EventHandler(this.MskbxSalario_Validated);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(370, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            this.txtNome.Validated += new System.EventHandler(this.TxtNome_Validated);
            // 
            // nupdFilhos
            // 
            this.nupdFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nupdFilhos.Location = new System.Drawing.Point(152, 106);
            this.nupdFilhos.Name = "nupdFilhos";
            this.nupdFilhos.Size = new System.Drawing.Size(88, 26);
            this.nupdFilhos.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.Location = new System.Drawing.Point(13, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(133, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Nome funcionário";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl2.Location = new System.Drawing.Point(13, 68);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 20);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Salário Bruto";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(13, 106);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(128, 20);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Número de filhos";
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Location = new System.Drawing.Point(152, 264);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.ReadOnly = true;
            this.txtAliqINSS.Size = new System.Drawing.Size(100, 20);
            this.txtAliqINSS.TabIndex = 6;
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Location = new System.Drawing.Point(152, 308);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.ReadOnly = true;
            this.txtAliqIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtAliqIRPF.TabIndex = 7;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Location = new System.Drawing.Point(152, 353);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.ReadOnly = true;
            this.txtSalFam.Size = new System.Drawing.Size(100, 20);
            this.txtSalFam.TabIndex = 8;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Location = new System.Drawing.Point(152, 391);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.ReadOnly = true;
            this.txtSalLiq.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiq.TabIndex = 9;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Location = new System.Drawing.Point(522, 262);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.ReadOnly = true;
            this.txtDescINSS.Size = new System.Drawing.Size(100, 20);
            this.txtDescINSS.TabIndex = 10;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Location = new System.Drawing.Point(522, 308);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.ReadOnly = true;
            this.txtDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtDescIRPF.TabIndex = 11;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl4.Location = new System.Drawing.Point(13, 264);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(109, 20);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Aliquota INSS";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl5.Location = new System.Drawing.Point(13, 308);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(108, 20);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "Aliquota IRPF";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl6.Location = new System.Drawing.Point(13, 351);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(112, 20);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "Salário Família";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl7.Location = new System.Drawing.Point(13, 391);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(113, 20);
            this.lbl7.TabIndex = 15;
            this.lbl7.Text = "Salário Líquido";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl8.Location = new System.Drawing.Point(374, 262);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(120, 20);
            this.lbl8.TabIndex = 16;
            this.lbl8.Text = "Desconto INSS";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl9.Location = new System.Drawing.Point(375, 308);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(119, 20);
            this.lbl9.TabIndex = 17;
            this.lbl9.Text = "Desconto IRPF";
            // 
            // butVerificar
            // 
            this.butVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butVerificar.Location = new System.Drawing.Point(219, 159);
            this.butVerificar.Name = "butVerificar";
            this.butVerificar.Size = new System.Drawing.Size(198, 59);
            this.butVerificar.TabIndex = 18;
            this.butVerificar.Text = "Verifica Desconto";
            this.butVerificar.UseVisualStyleBackColor = true;
            this.butVerificar.Click += new System.EventHandler(this.ButVerificar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butVerificar);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtSalFam);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.nupdFilhos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskbxSalario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupdFilhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown nupdFilhos;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtAliqINSS;
        private System.Windows.Forms.TextBox txtAliqIRPF;
        private System.Windows.Forms.TextBox txtSalFam;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Button butVerificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

