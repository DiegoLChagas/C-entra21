
namespace exercicios
{
    partial class cadastro
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.labelnome = new System.Windows.Forms.Label();
            this.labelletivo = new System.Windows.Forms.Label();
            this.txtanoLetivo = new System.Windows.Forms.TextBox();
            this.labelrespon = new System.Windows.Forms.Label();
            this.txtnomeR = new System.Windows.Forms.TextBox();
            this.labelrepon2 = new System.Windows.Forms.Label();
            this.txtnomeR2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcpfR2 = new System.Windows.Forms.TextBox();
            this.labelcpfR = new System.Windows.Forms.Label();
            this.txtcpfR = new System.Windows.Forms.TextBox();
            this.labelsexo = new System.Windows.Forms.Label();
            this.txtsexoA = new System.Windows.Forms.TextBox();
            this.txtdtNascimento = new System.Windows.Forms.TextBox();
            this.labelnascimento = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnlimpa = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 27);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(332, 23);
            this.txtnome.TabIndex = 0;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(12, 9);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(40, 15);
            this.labelnome.TabIndex = 1;
            this.labelnome.Text = "Nome";
            // 
            // labelletivo
            // 
            this.labelletivo.AutoSize = true;
            this.labelletivo.Location = new System.Drawing.Point(12, 76);
            this.labelletivo.Name = "labelletivo";
            this.labelletivo.Size = new System.Drawing.Size(64, 15);
            this.labelletivo.TabIndex = 3;
            this.labelletivo.Text = "Ano Letivo";
            // 
            // txtanoLetivo
            // 
            this.txtanoLetivo.Location = new System.Drawing.Point(12, 94);
            this.txtanoLetivo.Name = "txtanoLetivo";
            this.txtanoLetivo.Size = new System.Drawing.Size(332, 23);
            this.txtanoLetivo.TabIndex = 2;
            // 
            // labelrespon
            // 
            this.labelrespon.AutoSize = true;
            this.labelrespon.Location = new System.Drawing.Point(12, 141);
            this.labelrespon.Name = "labelrespon";
            this.labelrespon.Size = new System.Drawing.Size(108, 15);
            this.labelrespon.TabIndex = 5;
            this.labelrespon.Text = "Nome Responsavel";
            // 
            // txtnomeR
            // 
            this.txtnomeR.Location = new System.Drawing.Point(12, 159);
            this.txtnomeR.Name = "txtnomeR";
            this.txtnomeR.Size = new System.Drawing.Size(332, 23);
            this.txtnomeR.TabIndex = 4;
            // 
            // labelrepon2
            // 
            this.labelrepon2.AutoSize = true;
            this.labelrepon2.Location = new System.Drawing.Point(12, 204);
            this.labelrepon2.Name = "labelrepon2";
            this.labelrepon2.Size = new System.Drawing.Size(108, 15);
            this.labelrepon2.TabIndex = 7;
            this.labelrepon2.Text = "Nome Responsavel";
            // 
            // txtnomeR2
            // 
            this.txtnomeR2.Location = new System.Drawing.Point(12, 222);
            this.txtnomeR2.Name = "txtnomeR2";
            this.txtnomeR2.Size = new System.Drawing.Size(332, 23);
            this.txtnomeR2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "CPF Responsavel";
            // 
            // txtcpfR2
            // 
            this.txtcpfR2.Location = new System.Drawing.Point(444, 222);
            this.txtcpfR2.Name = "txtcpfR2";
            this.txtcpfR2.Size = new System.Drawing.Size(332, 23);
            this.txtcpfR2.TabIndex = 13;
            // 
            // labelcpfR
            // 
            this.labelcpfR.AutoSize = true;
            this.labelcpfR.Location = new System.Drawing.Point(444, 141);
            this.labelcpfR.Name = "labelcpfR";
            this.labelcpfR.Size = new System.Drawing.Size(96, 15);
            this.labelcpfR.TabIndex = 12;
            this.labelcpfR.Text = "CPF Responsavel";
            // 
            // txtcpfR
            // 
            this.txtcpfR.Location = new System.Drawing.Point(444, 159);
            this.txtcpfR.Name = "txtcpfR";
            this.txtcpfR.Size = new System.Drawing.Size(332, 23);
            this.txtcpfR.TabIndex = 11;
            // 
            // labelsexo
            // 
            this.labelsexo.AutoSize = true;
            this.labelsexo.Location = new System.Drawing.Point(444, 76);
            this.labelsexo.Name = "labelsexo";
            this.labelsexo.Size = new System.Drawing.Size(32, 15);
            this.labelsexo.TabIndex = 10;
            this.labelsexo.Text = "Sexo";
            // 
            // txtsexoA
            // 
            this.txtsexoA.Location = new System.Drawing.Point(444, 94);
            this.txtsexoA.Name = "txtsexoA";
            this.txtsexoA.Size = new System.Drawing.Size(332, 23);
            this.txtsexoA.TabIndex = 9;
            // 
            // txtdtNascimento
            // 
            this.txtdtNascimento.Location = new System.Drawing.Point(444, 27);
            this.txtdtNascimento.Name = "txtdtNascimento";
            this.txtdtNascimento.Size = new System.Drawing.Size(332, 23);
            this.txtdtNascimento.TabIndex = 8;
            // 
            // labelnascimento
            // 
            this.labelnascimento.AutoSize = true;
            this.labelnascimento.Location = new System.Drawing.Point(444, 9);
            this.labelnascimento.Name = "labelnascimento";
            this.labelnascimento.Size = new System.Drawing.Size(114, 15);
            this.labelnascimento.TabIndex = 15;
            this.labelnascimento.Text = "Data de Nascimento";
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(12, 292);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(169, 23);
            this.btnnovo.TabIndex = 16;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnlimpa
            // 
            this.btnlimpa.Location = new System.Drawing.Point(228, 292);
            this.btnlimpa.Name = "btnlimpa";
            this.btnlimpa.Size = new System.Drawing.Size(169, 23);
            this.btnlimpa.TabIndex = 17;
            this.btnlimpa.Text = "Limpa";
            this.btnlimpa.UseVisualStyleBackColor = true;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(444, 292);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(169, 23);
            this.btncad.TabIndex = 18;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(619, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 94);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(13, 27);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(131, 23);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.btnlimpa);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.labelnascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcpfR2);
            this.Controls.Add(this.labelcpfR);
            this.Controls.Add(this.txtcpfR);
            this.Controls.Add(this.labelsexo);
            this.Controls.Add(this.txtsexoA);
            this.Controls.Add(this.txtdtNascimento);
            this.Controls.Add(this.labelrepon2);
            this.Controls.Add(this.txtnomeR2);
            this.Controls.Add(this.labelrespon);
            this.Controls.Add(this.txtnomeR);
            this.Controls.Add(this.labelletivo);
            this.Controls.Add(this.txtanoLetivo);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.txtnome);
            this.Name = "cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelletivo;
        private System.Windows.Forms.TextBox txtanoLetivo;
        private System.Windows.Forms.Label labelrespon;
        private System.Windows.Forms.TextBox txtnomeR;
        private System.Windows.Forms.Label labelrepon2;
        private System.Windows.Forms.TextBox txtnomeR2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcpfR2;
        private System.Windows.Forms.Label labelcpfR;
        private System.Windows.Forms.TextBox txtcpfR;
        private System.Windows.Forms.Label labelsexo;
        private System.Windows.Forms.TextBox txtsexoA;
        private System.Windows.Forms.TextBox txtdtNascimento;
        private System.Windows.Forms.Label labelnascimento;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnlimpa;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}