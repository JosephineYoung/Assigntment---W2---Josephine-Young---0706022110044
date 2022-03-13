namespace week_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Data:";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(12, 43);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(391, 27);
            this.txtBoxInput.TabIndex = 1;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(12, 98);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(94, 29);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(12, 169);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutput.Size = new System.Drawing.Size(119, 38);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 252);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label lblOutput;
    }
}
