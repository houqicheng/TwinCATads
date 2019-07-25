namespace csADS
{
    partial class Main
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
            this.BtnForm1 = new System.Windows.Forms.Button();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnForm1
            // 
            this.BtnForm1.Location = new System.Drawing.Point(6, 86);
            this.BtnForm1.Name = "BtnForm1";
            this.BtnForm1.Size = new System.Drawing.Size(211, 37);
            this.BtnForm1.TabIndex = 0;
            this.BtnForm1.Text = "Read Primitive DataType";
            this.BtnForm1.UseVisualStyleBackColor = true;
            this.BtnForm1.Click += new System.EventHandler(this.BtnForm1_Click);
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.SystemColors.Info;
            this.txtExplain.Location = new System.Drawing.Point(6, 22);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(211, 57);
            this.txtExplain.TabIndex = 1;
            this.txtExplain.Text = "1, Read primitive data type";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.BtnForm1);
            this.groupBox1.Controls.Add(this.txtExplain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnForm1;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}