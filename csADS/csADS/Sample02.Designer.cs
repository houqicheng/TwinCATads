namespace csADS
{
    partial class Sample02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.realVal = new System.Windows.Forms.Label();
            this.txtLreal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtByte = new System.Windows.Forms.TextBox();
            this.txtDINT = new System.Windows.Forms.TextBox();
            this.txtINT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.txtReal);
            this.groupBox1.Controls.Add(this.realVal);
            this.groupBox1.Controls.Add(this.txtLreal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtByte);
            this.groupBox1.Controls.Add(this.txtDINT);
            this.groupBox1.Controls.Add(this.txtINT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmitting Structure to PLC";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(103, 179);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(112, 22);
            this.txtReal.TabIndex = 11;
            // 
            // realVal
            // 
            this.realVal.AutoSize = true;
            this.realVal.Location = new System.Drawing.Point(20, 184);
            this.realVal.Name = "realVal";
            this.realVal.Size = new System.Drawing.Size(52, 17);
            this.realVal.TabIndex = 10;
            this.realVal.Text = "realVal";
            // 
            // txtLreal
            // 
            this.txtLreal.Location = new System.Drawing.Point(103, 145);
            this.txtLreal.Name = "txtLreal";
            this.txtLreal.Size = new System.Drawing.Size(112, 22);
            this.txtLreal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "LrealVal";
            // 
            // txtByte
            // 
            this.txtByte.Location = new System.Drawing.Point(103, 109);
            this.txtByte.Name = "txtByte";
            this.txtByte.Size = new System.Drawing.Size(112, 22);
            this.txtByte.TabIndex = 5;
            // 
            // txtDINT
            // 
            this.txtDINT.Location = new System.Drawing.Point(103, 71);
            this.txtDINT.Name = "txtDINT";
            this.txtDINT.Size = new System.Drawing.Size(112, 22);
            this.txtDINT.TabIndex = 4;
            // 
            // txtINT
            // 
            this.txtINT.Location = new System.Drawing.Point(103, 36);
            this.txtINT.Name = "txtINT";
            this.txtINT.Size = new System.Drawing.Size(112, 22);
            this.txtINT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "byteVal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "dintVal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "invVal";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(85, 258);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(124, 35);
            this.btnWrite.TabIndex = 12;
            this.btnWrite.Text = "Write to PLC";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // Sample02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 314);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sample02";
            this.Text = "Sample02";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sample02_FormClosing);
            this.Load += new System.EventHandler(this.Sample02_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Label realVal;
        private System.Windows.Forms.TextBox txtLreal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtByte;
        private System.Windows.Forms.TextBox txtDINT;
        private System.Windows.Forms.TextBox txtINT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWrite;
    }
}