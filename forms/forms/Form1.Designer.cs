
namespace forms
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
            this.btnad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhist = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnsalve = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnad
            // 
            this.btnad.BackColor = System.Drawing.Color.Yellow;
            this.btnad.Location = new System.Drawing.Point(114, 186);
            this.btnad.Name = "btnad";
            this.btnad.Size = new System.Drawing.Size(93, 40);
            this.btnad.TabIndex = 3;
            this.btnad.Text = "+";
            this.btnad.UseVisualStyleBackColor = false;
            this.btnad.Click += new System.EventHandler(this.btnad_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "numero 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(441, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.Yellow;
            this.btnsub.Location = new System.Drawing.Point(255, 186);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(83, 40);
            this.btnsub.TabIndex = 4;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.Yellow;
            this.btnmult.Location = new System.Drawing.Point(383, 186);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(82, 40);
            this.btnmult.TabIndex = 5;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Yellow;
            this.btndiv.Location = new System.Drawing.Point(523, 186);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(86, 40);
            this.btndiv.TabIndex = 6;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(463, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "numero 2";
            // 
            // btnhist
            // 
            this.btnhist.Location = new System.Drawing.Point(367, 280);
            this.btnhist.Name = "btnhist";
            this.btnhist.Size = new System.Drawing.Size(75, 23);
            this.btnhist.TabIndex = 7;
            this.btnhist.Text = "historico";
            this.btnhist.UseVisualStyleBackColor = true;
            this.btnhist.Click += new System.EventHandler(this.btnhist_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(594, 280);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 8;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnsalve
            // 
            this.btnsalve.AutoSize = true;
            this.btnsalve.Location = new System.Drawing.Point(359, 255);
            this.btnsalve.Name = "btnsalve";
            this.btnsalve.Size = new System.Drawing.Size(56, 19);
            this.btnsalve.TabIndex = 9;
            this.btnsalve.Text = "salvar";
            this.btnsalve.UseVisualStyleBackColor = true;
            this.btnsalve.CheckedChanged += new System.EventHandler(this.btnsalve_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalve);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnhist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhist;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.CheckBox btnsalve;
    }
}

