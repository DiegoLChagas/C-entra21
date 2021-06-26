
namespace exercicios
{
    partial class Form7
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
            this.convert = new System.Windows.Forms.Button();
            this.celci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(247, 118);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(120, 35);
            this.convert.TabIndex = 0;
            this.convert.Text = "Converter em Fº";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // celci
            // 
            this.celci.Location = new System.Drawing.Point(232, 89);
            this.celci.Name = "celci";
            this.celci.Size = new System.Drawing.Size(145, 23);
            this.celci.TabIndex = 1;
            this.celci.TextChanged += new System.EventHandler(this.celci_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "coloque os Cº";
            // 
            // btncel
            // 
            this.btncel.Location = new System.Drawing.Point(489, 118);
            this.btncel.Name = "btncel";
            this.btncel.Size = new System.Drawing.Size(120, 35);
            this.btncel.TabIndex = 3;
            this.btncel.Text = "Converter em Cº";
            this.btncel.UseVisualStyleBackColor = true;
            this.btncel.Click += new System.EventHandler(this.btncel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "coloque os Fº";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celci);
            this.Controls.Add(this.convert);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox celci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}