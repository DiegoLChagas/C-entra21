
namespace exercicios
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
            this.btnex1 = new System.Windows.Forms.Button();
            this.btnex2 = new System.Windows.Forms.Button();
            this.btnex3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnex1
            // 
            this.btnex1.Location = new System.Drawing.Point(13, 13);
            this.btnex1.Name = "btnex1";
            this.btnex1.Size = new System.Drawing.Size(75, 23);
            this.btnex1.TabIndex = 0;
            this.btnex1.Text = "exercicio 1";
            this.btnex1.UseVisualStyleBackColor = true;
            this.btnex1.Click += new System.EventHandler(this.btnex1_Click);
            // 
            // btnex2
            // 
            this.btnex2.Location = new System.Drawing.Point(13, 51);
            this.btnex2.Name = "btnex2";
            this.btnex2.Size = new System.Drawing.Size(75, 23);
            this.btnex2.TabIndex = 1;
            this.btnex2.Text = "exercicio 2";
            this.btnex2.UseVisualStyleBackColor = true;
            this.btnex2.Click += new System.EventHandler(this.btnex2_Click);
            // 
            // btnex3
            // 
            this.btnex3.Location = new System.Drawing.Point(13, 91);
            this.btnex3.Name = "btnex3";
            this.btnex3.Size = new System.Drawing.Size(75, 23);
            this.btnex3.TabIndex = 2;
            this.btnex3.Text = "exercicio 3";
            this.btnex3.UseVisualStyleBackColor = true;
            this.btnex3.Click += new System.EventHandler(this.btnex3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "exercicio 4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnex3);
            this.Controls.Add(this.btnex2);
            this.Controls.Add(this.btnex1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnex1;
        private System.Windows.Forms.Button btnex2;
        private System.Windows.Forms.Button btnex3;
        private System.Windows.Forms.Button button1;
    }
}

