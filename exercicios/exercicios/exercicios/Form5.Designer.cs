
namespace exercicios
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.valor3 = new System.Windows.Forms.TextBox();
            this.valor4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnmult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(56, 46);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(100, 23);
            this.valor1.TabIndex = 1;
            this.valor1.TextChanged += new System.EventHandler(this.valor1_TextChanged);
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(56, 94);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(100, 23);
            this.valor2.TabIndex = 2;
            this.valor2.TextChanged += new System.EventHandler(this.valor2_TextChanged);
            // 
            // valor3
            // 
            this.valor3.Location = new System.Drawing.Point(56, 139);
            this.valor3.Name = "valor3";
            this.valor3.Size = new System.Drawing.Size(100, 23);
            this.valor3.TabIndex = 3;
            this.valor3.TextChanged += new System.EventHandler(this.valor3_TextChanged);
            // 
            // valor4
            // 
            this.valor4.Location = new System.Drawing.Point(56, 185);
            this.valor4.Name = "valor4";
            this.valor4.Size = new System.Drawing.Size(100, 23);
            this.valor4.TabIndex = 4;
            this.valor4.TextChanged += new System.EventHandler(this.valor4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "SOMA DOS VALORES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "D:";
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(232, 165);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(143, 62);
            this.btnmult.TabIndex = 12;
            this.btnmult.Text = "MULTIPLICAÇÃO DOS VALORES";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valor4);
            this.Controls.Add(this.valor3);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.TextBox valor3;
        private System.Windows.Forms.TextBox valor4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnmult;
    }
}