
namespace ContaOO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnnovaconta = new System.Windows.Forms.Button();
            this.txtnomeconta = new System.Windows.Forms.TextBox();
            this.Titular = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskvalor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnnovaconta
            // 
            this.btnnovaconta.Location = new System.Drawing.Point(105, 222);
            this.btnnovaconta.Name = "btnnovaconta";
            this.btnnovaconta.Size = new System.Drawing.Size(75, 23);
            this.btnnovaconta.TabIndex = 0;
            this.btnnovaconta.Text = "Saque";
            this.btnnovaconta.UseVisualStyleBackColor = true;
            this.btnnovaconta.Click += new System.EventHandler(this.btnnovaconta_Click);
            // 
            // txtnomeconta
            // 
            this.txtnomeconta.Location = new System.Drawing.Point(90, 67);
            this.txtnomeconta.Name = "txtnomeconta";
            this.txtnomeconta.ReadOnly = true;
            this.txtnomeconta.Size = new System.Drawing.Size(100, 23);
            this.txtnomeconta.TabIndex = 2;
            // 
            // Titular
            // 
            this.Titular.AutoSize = true;
            this.Titular.Location = new System.Drawing.Point(46, 115);
            this.Titular.Name = "Titular";
            this.Titular.Size = new System.Drawing.Size(40, 15);
            this.Titular.TabIndex = 3;
            this.Titular.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Conta";
            // 
            // mskvalor
            // 
            this.mskvalor.Location = new System.Drawing.Point(90, 167);
            this.mskvalor.Name = "mskvalor";
            this.mskvalor.Size = new System.Drawing.Size(100, 23);
            this.mskvalor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(91, 112);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.ReadOnly = true;
            this.txtTitular.Size = new System.Drawing.Size(100, 23);
            this.txtTitular.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titular);
            this.Controls.Add(this.txtnomeconta);
            this.Controls.Add(this.btnnovaconta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnovaconta;
        private System.Windows.Forms.TextBox txtnomeconta;
        private System.Windows.Forms.Label Titular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitular;
    }
}

