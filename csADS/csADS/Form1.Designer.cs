namespace csADS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadPrimitive = new System.Windows.Forms.Button();
            this.txtINT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadPrimitive);
            this.groupBox1.Controls.Add(this.txtINT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(176, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primitive Datetype";
            // 
            // btnReadPrimitive
            // 
            this.btnReadPrimitive.Location = new System.Drawing.Point(35, 281);
            this.btnReadPrimitive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReadPrimitive.Name = "btnReadPrimitive";
            this.btnReadPrimitive.Size = new System.Drawing.Size(64, 24);
            this.btnReadPrimitive.TabIndex = 2;
            this.btnReadPrimitive.Text = "Read";
            this.btnReadPrimitive.UseVisualStyleBackColor = true;
            this.btnReadPrimitive.Click += new System.EventHandler(this.btnReadPrimitive_Click);
            // 
            // txtINT
            // 
            this.txtINT.Location = new System.Drawing.Point(76, 26);
            this.txtINT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtINT.Name = "txtINT";
            this.txtINT.Size = new System.Drawing.Size(76, 21);
            this.txtINT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "int";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 338);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtINT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadPrimitive;
    }
}

